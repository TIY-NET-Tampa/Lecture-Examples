using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorFun
{
    class Parent
    {
        public string Name { get; set; }

        public Parent()
        {
            Console.WriteLine("No params");
        }

        public Parent(string n)
        {
            this.Name = n;
            Console.WriteLine($"Setting the Name in the Ctor to {n}");
        }

        public Parent(int age)
        {
            Console.WriteLine($"Your age is {age}");
        }

        public Parent(string x, int y)
        {

        }

        public Parent(int y, string x)
        {

        }
    }
}
