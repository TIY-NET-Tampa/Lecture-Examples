using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog : Pet, ISpeakable
    {

        public Dog() : base("Dalmation")
        {
            Console.WriteLine("Creating a dog");
        }

        public void Speak()
        {
            Console.WriteLine("bow wow");
        }
    }
}
