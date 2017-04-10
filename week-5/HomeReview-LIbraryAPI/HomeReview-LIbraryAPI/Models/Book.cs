using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HomeReview_LIbraryAPI.Models
{
    public class Book
    {
        public Book(){}
        public Book(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.Name = reader["Name"].ToString();
            this.DueBackDate = reader["DueBackDate"] as DateTime?;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime? DueBackDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string Genre { get; set; }
        public DateTime? LastCheckedOutDate { get; set; }
        public bool? IsCheckedOut { get; set; }
    }
}