using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks_EvenDiviblisty
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                var nString = Console.ReadLine();
                var nInt = int.Parse(nString);
                var count = nString
                    .Select(s => int.Parse(s.ToString()))
                    .Count(c => c != 0 && nInt % c == 0);
                Console.WriteLine(count);
                
            }
        }
    }
}







//var count = nString.Select(c => int.Parse(c.ToString())).Count(c => c != 0 && nInt % c == 0);
//Console.WriteLine(count);