using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        enum Operations
        {
            NoOperation = 0,
            Add,
            Subtract,
            Multiply,
            Divide
        }

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

        static Operations GetOperation()
        {
            var rv = Operations.NoOperation;
            var operation = String.Empty;
            var isKnown = false;
            while (!isKnown)
            {
                operation = Console.ReadLine();
                isKnown = true;
                switch (operation)
                {
                    case ("+"):
                        Console.WriteLine("Adding");
                        rv = Operations.Add;
                        break;
                    case ("-"):
                        Console.WriteLine("Subtracting");
                        rv = Operations.Subtract;
                        break;
                    case ("*"):
                        Console.WriteLine("Multiplying");
                        rv = Operations.Multiply;
                        break;
                    case ("/"):
                        Console.WriteLine("Division");
                        rv = Operations.Divide;
                        break;
                    default:
                        isKnown = false;
                        Console.WriteLine("No Idea");
                        break;
                }
            }

            return rv;
        }
        public class Card
        {
            public int Suit { get; set; }
            public int Rank { get; set; }

            public Card(int s, int r)
            {
                this.Suit = s;
                this.Rank = r;
            }
        }
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var card = new Card(input, 11);

            var r = card.Rank;
            card.Suit = 14;
            var num1 = GetNumber("Give me the first number");

            Console.WriteLine("What ist he operation?");
            var op = GetOperation();

            var num2 = GetNumber("Give me the second number");

            var answer = 0;
            switch (op)
            {
                case Operations.Add:
                    answer = Logic.Add(num1,num2);
                    break;
                case Operations.Subtract:
                    answer = Logic.Subtract(num1, num2);
                    break;
                case Operations.Multiply:
                    answer = Logic.Multiply(num1, num2);
                    break;
                case Operations.Divide:
                    answer = Logic.Division(num1, num2);
                    break;
            }

            Console.WriteLine($"{num1} {op} {num2} = {answer}");

            Console.ReadLine();






        }
    }
}
