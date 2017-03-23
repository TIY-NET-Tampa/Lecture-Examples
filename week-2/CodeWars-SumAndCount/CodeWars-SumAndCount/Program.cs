using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_SumAndCount
{
    /*
     Given an array of integers.

Return an array, where the first element 
is the count of positives numbers and 
the second element is sum of negative numbers.

If the input array is empty or null, return an empty array:

C#/Java: new int[] {} / new int[0];
         */
    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return new int[0];
            }
            var counter = 0;
            var sum = 0;
            foreach (var number in input)
            {
                if (number >= 0)
                {
                    counter++;
                }
                else if (number < 0)
                {
                    sum += number;
                }
            }
            return new int[] { counter, sum };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
