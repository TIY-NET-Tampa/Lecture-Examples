using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp_CompareTriplets
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);


            var aliceScores = 0;
            var bobScores = 0;

            for (int i = 0; i < tokens_a0.Count(); i++)
            {
                var a = int.Parse(tokens_a0[i]);
                var b = int.Parse(tokens_b0[i]);
                if (a > b)
                {
                    aliceScores++;
                } else if (a < b)
                {
                    bobScores++;
                } 
            }

            Console.WriteLine($"{aliceScores} {bobScores}");
        }
    }
}
