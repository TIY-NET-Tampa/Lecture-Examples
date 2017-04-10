using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HomeReview_LIbraryAPI.Models;
using System.Data.SqlClient;
using HomeReview_LIbraryAPI.Services;

namespace HomeReview_LIbraryAPI.Controllers
{
    /*
     - X How to handle Nulls  and externa system interfacing 
     -  X keyword: reference 
     - X Resource does not allow POST
     - X a Try catch!
     - X Sql Datetime vs .NET Datetime 
     - X Level 3 
     - skinny controlers and Interfaces and how they work here  
     - what is my stragety for breakin out the class/controller 
            into multiple controllesr & Models (ViewModel)
         */
    public class LibraryController : ApiController
    {
        IBookService bookService = new BookService();

        [HttpGet]
        [Authorize]
        public List<Book> GetAllBooks()
        {
            return bookService.GetAllBooks();
        }

        [HttpPost]
        public IHttpActionResult UpdateBook(int id, [FromBody]Book book)
        {
            IHttpActionResult rv;
            if (book == null)
            {
                throw new ArgumentNullException();
            }

            if (!String.IsNullOrEmpty(book.Name) && !String.IsNullOrEmpty(book.Author))
            {
                return BadRequest("Missing Name or Author");
            }

            try
            {
                var newBook = this.bookService.UpdateBook(id, book);
                rv = Ok(newBook);
            }
            catch (SqlException)
            {
                rv = Ok(new { Message = "Something went with sql" });
            }
            catch (Exception ex)
            {
                rv = Ok(new { Message = "Something went wrong somewhere", Error = ex.Message });
            }
            return rv;

        }
    }




}
}
