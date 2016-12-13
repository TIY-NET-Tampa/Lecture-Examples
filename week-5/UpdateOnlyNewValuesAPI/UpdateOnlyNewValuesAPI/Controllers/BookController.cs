using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UpdateOnlyNewValuesAPI.Models;
using System.Data.SqlClient;

namespace UpdateOnlyNewValuesAPI.Controllers
{
    public class BookController : ApiController
    {

        [HttpGet]
        public IHttpActionResult CheckOutBook(int bookId)
        {
            // if a book is not in, it should 
            // return a message that says that its not in with a message when its due back
            var book = GetBook(bookId);
            if (book.IsCheckOut)
            {
                // then.....
                var rv = new Dictionary<string, string>();
                rv.Add("message", $"This book is already checkout, due back {book.DueDate.ToString()}");
                return Ok(rv);
            } else
            {
                // check out book\
                //Services.CheckoutBook(book);
                return Ok(book);
            }
        }

        [HttpGet]
        public IHttpActionResult UpdateWithSQLInjection(Book newBook)
        {
            newBook.Name = "--;DELETE FROM Book";
            var sql =  $"UPDATE Book SET Name = {newBook.Name}"; 

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult UpdateBook(Book newBook)
        {
            // get the old book
            Book oldBook = GetBook(newBook.Id);


            // we want to update only values that new
            using (var conection = new SqlConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conection;
                    cmd.CommandType = System.Data.CommandType.Text;
                    // creating a SQL query with out column definition
                    var sql = @"UPDATE Books " +
                                " SET {0}" +
                                " WHERE Id=@Id";
                    // create a diction to hold the columns, new values 
                    var valuesToUpdate = new Dictionary<string, string>();

                    // compare each field 
                    if (newBook.Name != null && newBook.Name != oldBook.Name)
                    {
                        valuesToUpdate.Add("Name", newBook.Name);
                    }
                    if (newBook.Genre != oldBook.Genre)
                    {
                        valuesToUpdate.Add("Genre", newBook.Genre);
                    }


                    var updateStatement = "";
                    foreach (var newValues in valuesToUpdate.Keys)
                    {
                        updateStatement += $"{newValues}=@{newValues},";
                    }

                    //var str = "a" + "b" + "C";
                    //var output = String.Format("{0} {1} {2}", "a", "b", "c");


                    var full = "My fox jumps over the moon";
                    var sub = full.Substring(3); // fox jumps over the moon
                    var last = full.Substring(0, full.Length - 1); //My fox jumps over the moo

                    var command = String.Format(sql, updateStatement.Substring(0, updateStatement.Length - 1));
                    cmd.CommandText = command;

                    foreach (var newValues in valuesToUpdate.Keys)
                    {
                        cmd.Parameters.AddWithValue("@" + newValues, valuesToUpdate[newValues]);
                    }

                    conection.Open();
                    cmd.ExecuteNonQuery();
                    conection.Close();
                }
            }


            // build our update statement
            // run the update statement

            return Ok();
        }

        private Book GetBook(int id)
        {
            return new Book
            {
                Name = "Harold and the purple crayon",
                Genre = " Kids",
                YearPublished = "1990"
            }
        }
    }
}
