using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Services
{
    public class Review
    {
        public int Rating { get; set; }
        public string Details { get; set; }
        public bool IsSatisfactory { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
