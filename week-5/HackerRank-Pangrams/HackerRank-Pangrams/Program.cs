using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Replace(" ", String.Empty);

            var characters = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (characters.ContainsKey(item))
                {
                    characters[item]++;
                }
                else
                {
                    characters.Add(item, 1);
                }
            }
            if (characters.Count() == 26)
            {
                Console.WriteLine("pangram");
            }
            else
            {

                Console.WriteLine("not pangram");
            }
        }
    }
}
