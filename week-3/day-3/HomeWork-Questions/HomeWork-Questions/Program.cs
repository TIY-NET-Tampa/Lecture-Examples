using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Questions
{
    class Program
    {

        public static string ConvertCharaterToMorseCode(char letter)
        {
            return ".-.-.-";
        }


        static void Main(string[] args)
        {


            ///QUESTION: Displaying content and saving to a file
            ///

            var input = "this is from the user";

            var finalAnswer = String.Empty;
            foreach (var letter in input)
            {
                var temp = ConvertCharaterToMorseCode(letter);
                finalAnswer += temp;
                Console.WriteLine($"Converting {letter} ");
                Console.WriteLine($"{temp}");
            }

            Console.WriteLine("after loop");
            Console.WriteLine(finalAnswer);
            












            //var scores = new List<int> { 1, 4, 6, 3, 2, 3, 5, 7, 8, 9, };


            //var input = int.Parse(Console.ReadLine());

            //Console.WriteLine(input * input);


            //var answer = input * input;
            //Console.WriteLine(answer);
            //// save it to a file
            //using (var writer = File.AppendText("squeares.txt"))
            //{
            //    writer.WriteLine(answer);
            //}


            //// EXAMPLE  PROBLEM: We want to display and save the square of each score
            //var squares = new List<int>();
            //foreach (var score in scores)
            //{
            //    var square = score * score;
            //    squares.Add(square);
            //    Console.WriteLine(square);
            //}
            //// save it to a file
            //using(var writer = File.AppendText("squeares.txt"))
            //{
            //    foreach (var square in squares)
            //    {
            //        writer.WriteLine(square);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
