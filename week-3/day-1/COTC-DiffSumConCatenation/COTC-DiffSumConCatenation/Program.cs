using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COTC_DiffSumConCatenation
{
    class Program
    {
        /*
        // PROBLEM: Your program must read two numbers and output the concatenation of their difference and sum.
        INPUT:
            Two positive integers A and B.
        OUTPUT:
            The concatenated results of A-B and A+B.
        // EXAMPLE:
            in: 6 4
            out: 210
             
             */
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            var diff = A - B;
            var sum = A + B;
            
            var output = diff.ToString() + sum.ToString();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
