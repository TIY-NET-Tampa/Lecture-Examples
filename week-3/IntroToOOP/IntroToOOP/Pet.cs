using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    abstract class Pet
    {
        public string AnimalType { get; set; }
        public string Name { get; set; }
        public string HairColor { get; set; }
        
        public Pet() :this("cuddly")
        {
            Console.WriteLine("creating a new pet");
        }

        public Pet(string aType)
        {
            Console.WriteLine($"Creating an animal of type {aType}");
            this.AnimalType = aType;
        }
    }
}
