using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_CompareTriplets
{
    class Program
    {
        public static int Compare(int a, int b)
        {
            return (a > b) ? 1 : 0;
        }

        static public List<int> CreateList(List<int> valueA, List<int> valueB)
        {
            return new List<int> {
                  Compare(valueA[0], valueB[0]),
                  Compare(valueA[1], valueB[1]),
                  Compare(valueA[2],valueB[2]),
            };
        }

     
        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = int.Parse(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            
            var aliceValues = new List<int> { a0, a1, a2 };

            var bobValues = new List<int> { b0, b1, b2 };
            //var bob = 0;
            var alice = CreateList(aliceValues, bobValues);

            var bob = CreateList(bobValues, aliceValues);

            Console.WriteLine($"{alice.Sum()} {bob.Sum()}");





            //  keep track of the totals

            //CompareValues(a0, b0);
            //CompareValues(a1, b1);
            //CompareValues(a2, b2);
            //Console.WriteLine($"{alice} {bob}");


        }
        static int alice = 0;
        static int bob = 0;
        static public void CompareValues(int a, int b)
        {
            if (a > b)
            {
                alice++;
            }
            else if (b > a)
            {
                bob++;
            }
        }

    }
}
