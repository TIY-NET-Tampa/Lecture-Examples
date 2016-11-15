using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //var marks = new int[] { 99, 98, 92, 97, 95 };

            //var strs = new string[] { "hello", "wirld", "sup", "dawg" };

            //var helloWorld = strs[0] + " " + strs[1];

            //var confusing = new object[] { "hello", 4, false };
            //Console.WriteLine(confusing);

            //var arr = new int[9];

            //arr[4] = 44;
            //arr[2] = 11;

            //Console.WriteLine(arr);
            //Console.WriteLine(strs);
            //Console.WriteLine(arr[10]);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //var gameBoard = new int[8][];

            //for (int i = 0; i < gameBoard.Length; i++)
            //{
            //    gameBoard[i] = new int[8];
            //}

            //var myList = new List<int>();

            //myList.Add(10);
            //myList.Add(20);
            //myList.Add(30);


            //Console.WriteLine(myList[0]);
            //var board = new List<int[]>();


            //Console.WriteLine(helloWorld);

            //Goals:
            // how to access values in a list
            var list = new List<int> { 1, 2, 3, 4, 5 };


            var first = list.FirstOrDefault(f => f > 3);

            // query a list
            var evens = list.Where(num => num % 2 == 0);

            // does that same as the above line
            var evens2 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                var num = list[i];
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is evens");
                    evens2.Add(num);
                }
            }


            var numbers = new List<int> { 10, 20, 30, 40, 50 };
            // easy forloop, foreach loop
            foreach (var num in numbers.Where(w => w % 2 == 0))
            {
                Console.WriteLine(num);
            }

            // fizzbang
            /*
                Counts, 1 to 100
                 if the number is divisible by 3, print out only "Fizz", 
                 if the number is divisible by 5 print out only "bang", 
                 if the number is divisible by 3 and 5, print put only "fizzbang"
                 else, print out the number
             */
            Console.WriteLine("Starting Fizzbang");
            for (var i = 0; i <= 100; i++)
            {
                var output = i.ToString();
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output = "Fizzbang";
                }
                else if (i % 3 == 0)
                {
                    output = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    output = "bang";
                }
                Console.WriteLine(output);
            }

            // Enums


            Console.ReadLine();
        }
    }
}
