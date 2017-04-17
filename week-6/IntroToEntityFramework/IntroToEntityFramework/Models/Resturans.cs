using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework.Models
{
    class Resturans
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public virtual ICollection<Hometown> HomeTowns { get; set; }
    }
}
