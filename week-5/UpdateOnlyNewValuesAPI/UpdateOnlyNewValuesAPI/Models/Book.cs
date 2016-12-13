using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpdateOnlyNewValuesAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }
        public bool IsCheckOut { get; set; }
        public DateTime? DueDate { get; set; }
    }
}