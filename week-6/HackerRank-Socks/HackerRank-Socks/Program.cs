using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Socks
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            var socks = Array.ConvertAll(c_temp, Int32.Parse).ToList();


            var storage = new Dictionary<int, int>();
            foreach (var sock in socks)
            {
                if (storage.ContainsKey(sock))
                {
                    storage[sock]++;
                }
                else
                {
                    storage.Add(sock, 1);
                }
            }

            var totalPairs = 0;
            foreach (var color in storage.Keys)
            {
                totalPairs += storage[color] / 2;
            }
            Console.WriteLine(totalPairs);
        }

    }
}
