using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            // loop for n lines
            for (int i = 1; i <= n; i++)
            {
                Console.Write(" ".PadLeft(n-i-1));
                // print out sharp signs
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}
