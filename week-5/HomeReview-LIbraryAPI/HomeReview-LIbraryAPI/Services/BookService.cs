using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeReview_LIbraryAPI.Models;
using System.Data.SqlClient;
using HomeReview_LIbraryAPI.ViewModels;

namespace HomeReview_LIbraryAPI.Services
{
    public class BookService : IBookService
    {
        const string connectionString = @"Server=localhost\SQLEXPRESS;Database=Library;Trusted_Connection=True;";

        // TODO: make skinny!!!

        public Book GetBook(int id)
        {
            var book = new Book();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Catalog WHERE @Id = id";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        book = new Book(reader);
                    }
                }
                else
                {   
                    connection.Close();
                    throw new Exception("Book Not Found");
                }
                connection.Close();
            }
            return book;
        }

        private Book UpdateCheckedOutStatus(SqlConnection connection, Book book, bool checkOut)
        {
            book.IsCheckedOut = checkOut;
            if (checkOut)
            {
                book.DueBackDate = DateTime.Now.AddDays(10);
            }
            else
            {
                book.DueBackDate = null;
            }
            var checkOutQuery = @"UPDATE [dbo].[Catalog] SET { [DueBackDate] = @DueBackDate,[IsCheckedOut] = @IsCheckedOut WHERE Id = @Id";
            var checkOutCommand = new SqlCommand(checkOutQuery, connection);
            checkOutCommand.Parameters.AddWithValue("@Id", book.Id);
            checkOutCommand.Parameters.AddWithValue("@DueBackDate", (object)book.DueBackDate ?? DBNull.Value);
            
            // (book.DueBackDate != null) ? book.DueBackDate : DBNull.Value
            
            /*
                if (book.DueBackDate != null){
                    return book.DueBackDate;
                } else {
                    return DbNull.Value;    
                }
             
             */

            checkOutCommand.Parameters.AddWithValue("@IsCheckedOut", book.IsCheckedOut);
            connection.Open();
            checkOutCommand.ExecuteNonQuery();
            connection.Close();
            return book;
        }

        public CheckedOutViewModel CheckOutBook(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var book = this.GetBook(id);
                if (book.IsCheckedOut.GetValueOrDefault())
                {
                    // return the current due back date
                    return new CheckedOutViewModel(book, false, "That book cannot be checked out");
                }
                else
                {

                    //return the updated book;
                    book = this.UpdateCheckedOutStatus(connection, book, true);
                    // return the current due back date
                    return new CheckedOutViewModel(book, true, "That book was succesfully checked out");
                }
            }
        }

        public Book CheckInBook(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var book = this.GetBook(id);

                //return the updated book;
                book = this.UpdateCheckedOutStatus(connection, book, false);
                // return the current due back date
                return book;
            }
        }


        public List<Book> GetAllBooks()
        {
            var rv = new List<Book>();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Catalog";
                var cmd = new SqlCommand(query, connection);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rv.Add(new Book(reader));
                }
                connection.Close();
            }
            return rv;
        }

        public Book UpdateBook(int id, Book book)
        {
            Book rv = book;
            using (var connection = new SqlConnection(connectionString))
            {
                var query = @"UPDATE [dbo].[Catalog] SET { [Name] = @Name,[Author] = @Author WHERE Id = @Id";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Name", book.Name);
                try
                {
                    connection.Open();
                    var reader = cmd.ExecuteNonQuery();
                    book.Id = id;
                    rv = book;
                    return rv;
                }
                catch (SqlException ex)
                {
                    connection.Close();
                    throw new Exception(ex.Message);
                }


            }
        }

        public IEnumerable<Book> SearchBooksByName(string name)
        {
            var rv = new List<Book>();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Catalog WHERE Title LIKE @Name";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", $"%{name}%");
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rv.Add(new Book(reader));
                }
                connection.Close();
            }
            return rv;
        }
    }
}
