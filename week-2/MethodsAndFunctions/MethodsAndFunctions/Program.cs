using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndFunctions
{
    class Program
    {
        //static returnType MethondName([any parameters,...])
        //{

        //}

        static int GetValidUser()
        {
            var number = 0;
            var input = Console.ReadLine();
            var wasSuccessful = int.TryParse(input, out number);
            while (!wasSuccessful)
            {
                Console.WriteLine("Try again");
                wasSuccessful = int.TryParse(input, out number);
            }
            return number;
        }

        static int GetUserNumber(string putput)
        {
            Console.WriteLine(putput);
            var number = GetValidUser();
            return number;
        }

        static void Main(string[] args)
        {
            var first = GetUserNumber("Enter First Number");
        
            var second = GetUserNumber("Enter Second Number");

            var result = first + second;

            Console.WriteLine($"Your addition is {first} + {second} = {result}");

        }
    }
}
