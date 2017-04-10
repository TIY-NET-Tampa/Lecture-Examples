using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeReview_LIbraryAPI.Models;

namespace HomeReview_LIbraryAPI.Services
{
    interface IBookService
    {
        List<Book> GetAllBooks();
        Book UpdateBook(int id, Book book);        
    }
}