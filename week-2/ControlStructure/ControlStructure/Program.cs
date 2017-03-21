using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("What is your favorite color?");
            //var userColor = Console.ReadLine();


            //// bool
            ////if (exp that evaluates to true or false)
            ////{
            ////  Executes if experssion is true
            ////  Your code goes here
            ////}
            ////else {
            //// executes if exp is false
            ////}


            ////TODO: change to string comparsion
            //if (userColor == "yellow")
            //{
            //    Console.WriteLine("Yellow is the best color");
            //}
            //else if (userColor == "blue")
            //{
            //    Console.WriteLine("Blue is boootiful");
            //}
            //else if (userColor == "green")
            //{
            //    Console.WriteLine("Woooooot! Like Grass!");
            //}
            //else
            //{
            //    Console.WriteLine("yeah that color is okay");
            //}

            //// block hold ctrl, press K then C
            //Console.WriteLine("What is your lucky number?");
            //var userNumber = int.Parse(Console.ReadLine());

            //// auto formating
            //// ctrl + K + d
            //if (userNumber == 55 || userNumber == 14)
            //{
            //    Console.WriteLine("Hey! me Too!");
            //}
            //else if (userNumber <=50 && (userNumber > 40 && userNumber > 60))
            //{

            //}
            //else if (!(userNumber >= 100))
            //{
            //    var length = userNumber.ToString().Length;
            //    Console.WriteLine("THats too da** high");
            //}
            //else if (userNumber < 10)
            //{
            //    Console.WriteLine("get low");
            //}


            //Console.WriteLine("What is your phone number?");
            //var value = 0;
            //var wasSuccessful = !(int.TryParse(Console.ReadLine(), out value));
            //if (!wasSuccessful)
            //{
            //    Console.WriteLine("Not even a number, bro");
            //}
            //if (value.ToString().Length != 10)
            //{
            //    Console.WriteLine("You have been played");
            //}
            //Console.WriteLine("Thank you, have a good day");


            ///varibles -- Pre Array days
            var myNumber = 101;

            var player1 = 45;
            var player2 = 25;
            var player3 = 15;
            var player4 = 88;
            var player5 = 0;
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            Console.WriteLine(player3);
            Console.WriteLine(player4);
            Console.WriteLine(player5);

            // Arrays
            // var myVarible = new <type>[length];

            var teamNumbers = new int[7];
            teamNumbers[0] = 45;
            teamNumbers[2] = 15;
            teamNumbers[1] = 25;

            var visitors = new int[] { 4, 13, 56, 77, 88, 99  };

            var pointGuard = visitors[0];

            var benchWarmer = teamNumbers[6];

            // For loop
            //   ( counter init; stopping condition;incrementor )
            for (var i = 0; i < visitors.Length; i ++)
            {
                if (visitors[i] < 20)
                {
                    Console.WriteLine("you are benched");
                }
                else
                {
                    Console.WriteLine($"Player number = {visitors[i]}");
                }
            }

            foreach (var num in visitors)
            {
                Console.WriteLine($"foreach, player num = {num}");
            }


            // While loop

            //while (exp that evals to t/f)
            //{

            //}

            while (true)
            {
                Console.WriteLine("hello");
            }

            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"my count is {counter}");
                counter++;
            }

            //Console.WriteLine("Give me your jersey number:");
            //var rawInput = Console.ReadLine();
            //int newNumber;
            //var wasSuccessful = int.TryParse(rawInput, out  newNumber);
            //while (!wasSuccessful)
            //{
            //    Console.WriteLine("That was not a number, try again");
            //    rawInput = Console.ReadLine();
            //    wasSuccessful = int.TryParse(rawInput, out newNumber);
            //}
           


            // do while
            var wasSuccessful = false;
            int newNumber;
            do
            {
                Console.WriteLine("Give me your jersey number:");
                var rawInput = Console.ReadLine();
                wasSuccessful = int.TryParse(rawInput, out newNumber);
            } while (!wasSuccessful);
            Console.WriteLine($"you number is {newNumber}");
        }
    }
}
