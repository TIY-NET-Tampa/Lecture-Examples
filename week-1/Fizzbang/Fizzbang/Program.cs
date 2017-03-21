using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbang
{
    class Program
    {
        static void Main(string[] args)
        {
            /// a programin that counts from 0 to 100
            /// if the number if div by 3 -. "Fizz"
            /// else if div by 5 -> "Bang"
            /// else if div by 3 && 5 -> "FizzBang"
            /// else print i
            /// 

            for (int i = 0; i <= 100; i++)
            {

                if (i % 3 == 0 && i% 5 == 0)
                {
                    Console.WriteLine("FizzBang");
                }
                else if ((i/3)  == (i/(float)3)) // num / 3 == a whole number
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Bang");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
                                                                        
            var number = 0;
            while (number <= 100)
            {
                if (number % 15 == 0)
                {
                    Console.WriteLine("FizzBang");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Bang");
                }
                else
                {
                    Console.WriteLine(number);
                }
              
                    number++;
            }


            // integer divisions

            Console.WriteLine(5/2);
            Console.WriteLine(5f/2);
            Console.WriteLine(5/2.3);
            Console.WriteLine(5/2f);
        }
    }
}   
