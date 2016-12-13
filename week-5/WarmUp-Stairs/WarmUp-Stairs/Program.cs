using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp_Stairs
{
    // https://www.hackerrank.com/challenges/staircase
    class Program
    {
        /*
         Create a console app that outputs a staircase N levels. 

            example: 
            
            Input: 
            4

            Output:
                #
               ##
              ###
             ####

             */
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            // step 1: print the correct lines
            // print the correct vertical lines
            for (int i = 0; i < n; i++)
            {
                var spaces = n - i - 1;
                // write out spaces
                for (int k = 0; k < spaces; k++)
                {
                    Console.Write(" ");
                }
                // step 2:printing out the correct lateral characters
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                // After print out a line, then we want to move to the next line
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
