namespace HomeworkReview_WebAPIAndEF.Migrations
{
    using HomeworkReview_WebAPIAndEF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeworkReview_WebAPIAndEF.DataContext.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeworkReview_WebAPIAndEF.DataContext.LibraryContext context)
        {
            var books = new List<Book>
            {
                new Book{Title = "Purple Crayon"},
                new Book{ Title ="Catcher & The Rye", DateCheckedOut = new DateTime(2017, 4, 20)}, 
                new Book{Title = "1984", DateCheckedOut = new DateTime(2017, 4, 13)}
            };

            books.ForEach(book => context.Books.AddOrUpdate(b => b.Title, book));
            context.SaveChanges();
        }
    }
}
