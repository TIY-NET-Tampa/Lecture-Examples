using HomeReview_LIbraryAPI.Models;
using HomeReview_LIbraryAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeReview_LIbraryAPI.Controllers
{
    public class SearchController : ApiController
    {
        IBookService bookService = new BookService();

        [HttpGet]
        public IEnumerable<Book> SearchByName(string name)
        {
            return bookService.SearchBooksByName(name);
        } 
    }
}
