using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2HomeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = new Random().Next(1,101);
            Console.WriteLine($"the target is {target}");

            Console.WriteLine("Give me your best guess");
            var input = Console.ReadLine();
            var guess = 0;
            int.TryParse(input, out guess);

            Console.WriteLine($"your guess was {guess}");


            if (guess < target)
            {
                Console.WriteLine("Too low");
            }
            else if (guess > target)
            {
                Console.WriteLine("Too high");
            }


        }
    }
}
