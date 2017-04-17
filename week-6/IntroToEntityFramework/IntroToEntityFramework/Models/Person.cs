using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework.Models
{
    class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string HairColor { get; set; }
        public bool IsRightHanded { get; set; }
        public double Height { get; set; }
        public int? Age { get; set; }

        public int? HomeTownId { get; set; }
        public Hometown HomeTown { get; set; }


    }
}
