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
            var sentence = Console.ReadLine().Trim();
            //var dict = sentence.Where( w => w != ' ').GroupBy(key => key, value => sentence.Count(c => c == value));
            var other = new Dictionary<char, int>();
            foreach (var letter in sentence)
            {
                if (letter != ' ')
                {
                    if (other.ContainsKey(letter))
                    {
                        other[letter]++;
                    }
                    else
                    {
                        other.Add(letter, 1);
                    }
                }
            }
            if (other.Count() == 26)
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
