using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);


            while (arr.Any())
            {
                // print out the number of elements (how many we are cutting)
                Console.WriteLine(arr.Length);
                // "Cut"
                // find min
                var min = arr.Min();
                // subtract min from all numbers
                // filter out the 0s
                arr = arr.Select(s => s - min).Where(w => w > 0).ToArray();
            }

        }
    }
}
