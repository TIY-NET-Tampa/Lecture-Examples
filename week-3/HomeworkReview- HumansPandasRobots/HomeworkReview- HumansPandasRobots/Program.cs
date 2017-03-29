using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview__HumansPandasRobots
{
    /*
     Questions:
     X interfaces are still fuzzy
     X virtual is still unclear
     X abstract 
     x level 3 ...reflection??
     - overloading a operator 
         */
    class Program
    {
        static void Main(string[] args)
        {
            var something = new Human();
            something.Name = "billy Bob";

            var mingMing = new Panda();
            mingMing.DisplayGreeting();

            var room = new List<IGreeter>()
            {
                new Human(), new Panda(), new Robot()
            };

            foreach (var item in room)
            {
                item.DisplayGreeting();
            }

            var sirPanda = new Panda();

            var baby = mingMing + sirPanda;
            Console.WriteLine(baby.Name);
        }
    }
}
