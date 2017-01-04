using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Socks
{
    class Program
    {
        public static int OneLine(int n, IEnumerable<int> socks)
        {
            //TODO: ask this question.....
            var matched = socks
                .Distinct()
                .ToDictionary(key => key, value => socks.Count(c => c == value))
                .Sum(color =>
                {
                    var pairs = color.Value / 2;
                    return pairs;
                });
            return matched;
        }

        public static int ExpandedWay(int n, IEnumerable<int> socks)
        {
            var totalSocks = 0;
            var storage = new Dictionary<int, int>();
            foreach (var sock in socks)
            {
                if (storage.ContainsKey(sock))
                {
                    storage[sock] += 1;
                }
                else
                {
                    storage.Add(sock, 1);
                }
            }

            foreach (var pile in storage.Keys)
            {
                var countOfSocks = storage[pile];
                totalSocks += countOfSocks / 2;
            }
            return totalSocks;
        }

        public static int NoDictionary(int n, IEnumerable<int> socks)
        {
            var rv = 0;
            var colors = socks.Distinct();
            foreach (var color in colors)
            {
                var countOfSocks = socks.Count(c => c == color);
                if (countOfSocks % 2 == 0)
                {
                    rv += countOfSocks / 2;
                }
                else
                {
                    rv += (countOfSocks - 1) / 2;
                }
            }
            return rv;
        }

        public static int NoLinqNoDictionary(int n, IEnumerable<int> socks)
        {
            var rv = 0;
            var distinctColors = new List<int>();
            foreach (var color in socks)
            {
                var found = false;
                foreach (var item in distinctColors)
                {
                    if (color == item)
                    {
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                    }

                }
                if (!found)
                {
                    distinctColors.Add(color);
                }
            }
            foreach (var color in distinctColors)
            {
                var countOfSocks = 0;
                foreach (var sock in socks)
                {
                    if (sock == color)
                    {
                        countOfSocks++;
                    }
                }
                if (countOfSocks % 2 == 0)
                {
                    rv += countOfSocks / 2;
                }
                else
                {
                    rv += (countOfSocks - 1) / 2;
                }
            }
            return rv;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            var socks = Array.ConvertAll(c_temp, Int32.Parse);
            var matched = NoLinqNoDictionary(n, socks);
            Console.WriteLine(matched);


        }
    }
}
