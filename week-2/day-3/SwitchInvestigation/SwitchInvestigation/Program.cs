using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var guessedNumber = "test";
            //switch (guessedNumber)
            //{
            //    case ("test"):
            //        Console.WriteLine("got here for 1");
            //        break;
            //    case ("other"):
            //        Console.WriteLine("got here for 2");
            //        break;
            //    case ("):
            //        Console.WriteLine("got here for 3");
            //        break;
            //    default:
            //        Console.WriteLine("Nope!");
            //        break;
            //}

            //if (guessedNumber == 1)
            //{
            //    Console.WriteLine("got here for 1");
            //}
            //else if (guessedNumber == 2)
            //{
            //    Console.WriteLine("got here for 2");
            //}
            //else if (guessedNumber == 3)
            //{
            //    Console.WriteLine("got here for 3");
            //}
            //else
            //{
            //    Console.WriteLine("Nope!");
            //}

            // Problem: We want while, 
            // that loops until they guess the correct number, 
            // then it changes the display message accordingly 
            // and breaks out of the loop

            Console.Write("enter number:");
            var guessed = int.Parse(Console.ReadLine());
            var answer = 42;
            var attempts = 1;
            var maxAttempts = 5;

            while (attempts <= maxAttempts)
            {
                
                if (guessed == answer)
                {
                    Console.WriteLine("You did it");
                }
                else
                {
                    Console.WriteLine($"You have guessed {attempts} times");
                    if (attempts > maxAttempts - 1)
                    {
                        Console.WriteLine("You have tried too many times");
                    } else
                    {
                        Console.WriteLine("try again");
                        guessed = int.Parse(Console.ReadLine());
                    }
                }
                attempts++;
            }


            Console.ReadLine();

        }
    }
}
