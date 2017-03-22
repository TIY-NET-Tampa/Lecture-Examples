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
            var target = new Random().Next(1, 101);
            Console.WriteLine($"the target is {target}");

            var counter = 0;
            var guess = 0;

            while (counter < 5 && guess != target)
            {
                Console.WriteLine("Give me your best guess");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                Console.WriteLine($"your guess was {guess}");

                if (guess < target)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Too high, try again");
                }
                counter++;
            }

            if ()


}
    }
}
