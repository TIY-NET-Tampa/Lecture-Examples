using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static int GetNumber(string message)
        {
            Console.WriteLine(message);
            var num = 0;
            var isNum = int.TryParse(Console.ReadLine(), out num);
            if (isNum)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Not a number");
            }
            return num;
        }

        static void Main(string[] args)
        {
            var num1 = GetNumber("Give me the first number");
           
            Console.WriteLine("What ist he operation?");
            var op = Console.ReadLine();

            var num2 = GetNumber("Give me the second number");
           
            Console.WriteLine($"{num1} {op} {num2}");

            Console.ReadLine();






        }
    }
}
