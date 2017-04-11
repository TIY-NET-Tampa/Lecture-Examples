using HomeReview_LIbraryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeReview_LIbraryAPI.ViewModels
{
    public class CheckedOutViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool WasCheckedOut { get; set; }
        public DateTime DueBackDate { get; set; }
        public string Message { get; set; }

        public CheckedOutViewModel(Book book, bool wasCheckedOut, string message)
        {
            Id = book.Id;
            Name = book.Name;
            DueBackDate = book.DueBackDate.Value;
            WasCheckedOut = wasCheckedOut;
            Message = message;
        }
    }
}