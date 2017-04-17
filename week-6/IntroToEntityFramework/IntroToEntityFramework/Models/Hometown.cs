using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework.Models
{
    class Hometown
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }

        public virtual ICollection<Resturans> Resturans { get; set; }
    }
}
