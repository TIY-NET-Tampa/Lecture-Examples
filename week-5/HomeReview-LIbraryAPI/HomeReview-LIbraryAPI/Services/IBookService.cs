using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeReview_LIbraryAPI.Models;
using HomeReview_LIbraryAPI.ViewModels;

namespace HomeReview_LIbraryAPI.Services
{
    interface IBookService
    {
        List<Book> GetAllBooks();
        Book UpdateBook(int id, Book book);
        CheckedOutViewModel CheckOutBook(int id);
        IEnumerable<Book> SearchBooksByName(string name);
    }
}