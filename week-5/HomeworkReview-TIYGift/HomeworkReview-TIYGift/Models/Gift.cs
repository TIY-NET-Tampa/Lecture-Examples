using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkReview_TIYGift.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public string Contents { get; set; }
        public string Hints { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Depth { get; set; }
        public double? Weight { get; set; }
        public bool? IsOpened { get; set; } = false;
    }
}