using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeReview_LIbraryAPI.Models;
using System.Data.SqlClient;

namespace HomeReview_LIbraryAPI.Services
{
    public class BookService : IBookService
    {
        const string connectionString = @"Server=localhost\SQLEXPRESS;Database=Library;Trusted_Connection=True;";
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
    }
}
}