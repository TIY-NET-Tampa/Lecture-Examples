using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Pet
    {
        public int Age { get; set; } = 0;
        public string Name { get; set; }

        public string Breed { get; set; }
        public string Color { get; set; }
    }
}
