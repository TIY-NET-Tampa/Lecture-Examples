using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_PDFViewer
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();

            var counter = 0;
            // convert to dictionary of char, int
            var datasource = "abcdefghijklmnopqrstuvwxyz".ToDictionary(key => key, value =>
            {
                var rv = numbers[counter];
                counter++;
                return rv;
            });

            // create list of numbers &
            // find tallest
            var h = word.Select(ch => datasource[ch]).OrderByDescending(o => o).First();
            // sum up length
            var l = word.Length;
            // multiply
            var A = l * h;



            var oneLine = "abcdefghijklmnopqrstuvwxyz"
                .Select((ch, pos) => new { ch, pos })
                .ToDictionary(key => key.ch, value => numbers[value.pos])
                .Where(s => word.Contains(s.Key))
                .OrderByDescending(o => o.Value)
                .Select(s => s.Value * l)
                .First();

            Console.WriteLine(oneLine);
            Console.ReadLine();
        }
    }
}
