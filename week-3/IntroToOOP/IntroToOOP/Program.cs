using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is their name:");
            var name = Console.ReadLine();

            var mark = new Person(name);
            mark.Age = 28;
            mark.HairColor = "Brown";

       
            var otherMark = new Person("otherMark")
            {
                Age = 28,
                HairColor = "Brown",
                Height = 73
            };

        }
    }
}
