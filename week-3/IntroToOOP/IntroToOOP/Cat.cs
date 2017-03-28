using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat : Pet, ISpeakable
    {
        public Cat(string Name) : base()
        {
            Console.WriteLine("Createing a new Cat");
        }

        public void Speak()
        {
            Console.WriteLine("Meoooooow");
        }
    }
}
