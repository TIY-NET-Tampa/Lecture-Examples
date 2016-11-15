using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDeLoop
{
    class Program
    {
        static void Main(string[] args)
        {


            //var count = 0;
            //var other = 0;

            //Console.WriteLine($"{count++} and {++other}");

            //var counter = 0;
            //// do while
            //do
            //{
            //    counter++;
            //    Console.WriteLine(counter);
            //} while (counter < 10);

            //var num = 0;
            //do
            //{
            //    Console.WriteLine("Give me a number above 50");
            //    var input = Console.ReadLine();
            //    num = int.Parse(input);
            //} while (num < 50);

            //Console.WriteLine("succss!");

            //// while
            //var anotherCounter = 0;
            //while (anotherCounter > 10)
            //{
            //    anotherCounter++;
            //    Console.WriteLine(anotherCounter);
            //}

            var num2 = 100;
            while (num2 < 50)
            {
                Console.WriteLine("Give me a number above 50");
                var input = Console.ReadLine();
                num2 = int.Parse(input);
            }
          

            //// for 
            //for (var i = 0; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}



            Console.ReadLine();

        }
    }
}
