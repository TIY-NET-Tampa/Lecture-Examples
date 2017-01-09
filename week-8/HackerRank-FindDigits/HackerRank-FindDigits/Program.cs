using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            var cases = new List<string>();
            for (int a0 = 0; a0 < t; a0++)
            {
                var n = Console.ReadLine();
                cases.Add(n);
            }

            foreach (var N in cases)
            {
                var counter = 0;
                var split = N.Select(s => int.Parse(s.ToString()));
                var n = int.Parse(N);
                foreach (var digit in split)
                {
                    if (digit != 0 && n % digit == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
            }
            Console.ReadLine();
        }

    }
}
