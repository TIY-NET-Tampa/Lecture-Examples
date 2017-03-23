using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2HomeReview.Logic
{
    static class NumberGuesser
    {
        static List<int> pastGuess = new List<int>();


        static int ReadNumberFromTerminal()
        {
            Console.WriteLine("Give me your best guess");
            var input = Console.ReadLine();
            int.TryParse(input, out int guess);
            return guess;
        }

        static void DisplayPastGuess()
        {
            Console.WriteLine("Your past guesses are:");
            foreach (var userGuess in pastGuess)
            {
                if (userGuess != 0)
                {
                    Console.Write($"{userGuess},");
                }
            }
        }

        static bool WasAlreadyGuessed(int guess)
        {
            var wasAlreadyGuess = false;

            foreach (var userGuess in pastGuess)
            {
                if (guess == userGuess)
                {
                    wasAlreadyGuess = true;
                }
            }
            return wasAlreadyGuess;
        }

        static void AddToGuesses(int guess)
        {
            pastGuess.Add(guess);
        }


        static void DisplayTooHighOrTooLowMessage(int guess, int target)
        {
            Console.WriteLine($"your guess was {guess}");
            // low logic
            if (guess < target)
            {
                Console.WriteLine("Too low, try again.");
            }
            // high logic
            else if (guess > target)
            {
                Console.WriteLine("Too high, try again");
            }
        }

        public static int GenerateRandomNumber(int min, int max)
        {
            var target = new Random().Next(min, max + 1);
            Console.WriteLine($"the target is {target}");
            return target;
        }

        public static void DisplayEndCredits(int counter)
        {
            if (counter > 4)
            {
                Console.WriteLine("You lost :-(");
            }
            else
            {
                Console.WriteLine("You Won!");
            }
        }

        public static int GameLoop(int target)
        {
            var counter = 0;
            var guess = 0;
            while (counter < 5 && guess != target)
            {
                // Read in number from CLI
                guess = ReadNumberFromTerminal();

                // See if the number was already guessed
                var wasAlreadyGuess = WasAlreadyGuessed(guess);

                if (wasAlreadyGuess)
                {
                    Console.WriteLine("You already guesses that, foool");
                }
                else
                {
                    // add to pastguesses
                    AddToGuesses(guess);


                    DisplayTooHighOrTooLowMessage(guess, target);
                }
                // display past guesses
                DisplayPastGuess();
                // increment guess counter
                counter++;
            }
            return counter;
        }

    }
}
