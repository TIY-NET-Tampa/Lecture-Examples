using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_MinManxSum
{
    class Program
    {

        public static void NonLinq()
        {
            var input = Console.ReadLine().Split(' ').Select(s => long.Parse(s));

            // find the min/find the max
            var min = long.MaxValue;
            var max = long.MinValue;
            var total = 0L;
            foreach (var number in input)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
                total += number;
            }

            Console.WriteLine($"{total - max} {total - min}");

        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(s => long.Parse(s)).OrderBy(num => num).ToList();

            var min = input.Take(input.Count - 1).Sum();
            var max = input.Skip(1).Sum();

            var output = $"{min} {max}";
            Console.WriteLine(output);
        }
    }
}
