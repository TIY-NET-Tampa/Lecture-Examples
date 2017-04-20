using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIAndEF.Models
{
    public class Sandwhich
    {
        public int Id { get; set; }
        public string Bread { get; set; }
        public string MainItem { get; set; }
        public bool HasLettuce { get; set; }
        public string Cheese { get; set; }
    }
}