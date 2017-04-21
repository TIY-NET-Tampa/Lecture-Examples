using HomeworkReview_WebAPIAndEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeworkReview_WebAPIAndEF.DataContext
{
    public class LibraryContext :DbContext
    {
        public LibraryContext():base()
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}