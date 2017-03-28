using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Iguana :Pet
    {
        public int FangLength { get; set; }


        public Iguana()
        {
            Console.WriteLine("Creating an Iguana");
        }
    }
}
