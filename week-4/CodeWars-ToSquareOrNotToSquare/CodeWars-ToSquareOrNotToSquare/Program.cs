using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_ToSquareOrNotToSquare
{
    /*
    If the number has an integer square root, 
    take this, otherwise square the number.

     [4,3,9,7,2,1] -> [2,9,3,49,4,1]
     */

    public class Kata
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {

            var rv = new List<int>();
            // loop 
            foreach (var number in array)
            {
                // determine if its rootabnle to  an int
                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    // it is an integer Sqrt
                    rv.Add((int)Math.Sqrt(number));
                }
                else
                {
                    // not an integer sqrt
                   rv.Add(number * number);
                }
            }
            Math.
            return rv.ToArray();
        }
    }






    public class Kata_Mine
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                var value = array[i];
                var sqrt = Math.Sqrt(value);
                if (sqrt != (int)sqrt)
                {
                    // then it is an integer
                    array[i] = (int)Math.Pow(value, 2);
                }
                else
                {
                    array[i] = (int)sqrt;
                }

            }
            return array;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
