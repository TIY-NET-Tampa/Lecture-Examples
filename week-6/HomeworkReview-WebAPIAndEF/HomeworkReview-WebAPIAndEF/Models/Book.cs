using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkReview_WebAPIAndEF.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateAddedToLibrary { get; set; } = DateTime.Now;
        public DateTime? DateCheckedOut { get; set; }
        public DateTime? DueBackDate
        {
            get {
                return (DateCheckedOut.HasValue) ?
                   DateCheckedOut.Value.AddDays(10) : null as DateTime?;
            } 
        }
    }
}