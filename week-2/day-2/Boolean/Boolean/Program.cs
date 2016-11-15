using System;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            var havePets = true;
            var haveCats = false;
            var haveDogs = true;
            var haveIguana = false;

            /*
            // A && B = 
            true if both sides are true,
            else will be false
            */
            //if ((havePets && haveCats) && (haveDogs && haveIguana))
            //{
            //    Console.WriteLine("I am a zookeeper");
            //}

            //var x = 50;

            //if (x == "anything, cats dogs, whatever")
            //{
            //    Console.WriteLine("Woot woot, you got it");
            //}
            //else
            //{
            //    Console.WriteLine("Nope, not enough");
            //}

            //Console.WriteLine("What is your favorite color");
            //var input = Console.ReadLine();
            //var color = input.ToLower();
            //if (String.Compare(color, "red", true) == 0)
            //{
            //    Console.WriteLine("You like red, like a strawberry");
            //}
            //else if (String.Compare(color, "green") == 0)
            //{
            //    Console.WriteLine("You like green, like grass!!!");
            //}
            //else
            //{
            //    Console.WriteLine("I do not know that color");
            //}

            //Console.WriteLine(String.Compare("B", "A") == 0);
            //Console.WriteLine(String.Compare("A", "A") == 0);

            //if (String.Compare("This is one thing", "The cat goes meow") == 0)
            //{
            //    Console.WriteLine("they are equal");
            //}
            //else
            //{
            //    Console.WriteLine("they are not");
            //}


            //if (false && false)
            //{
            //    Console.WriteLine("Should not show");
            //}

            /*           
            // A || C = 
            true if at least one side is true
            false if both sides are false

            */

            //if (haveCats || haveDogs)
            //{
            //    Console.WriteLine("YOu have normal pets");
            //}
            //else if (havePets || haveIguana)
            //{
            //    Console.WriteLine("You are unique");
            //}


            /*
            // !A
            true if A is false
            false if A true
            */

            //var x = 50;

            //if ( x != 100)
            //{
            //    Console.WriteLine("Take a break!");
            //}



            /*
            //if (haveDogs)
            //{
            //    Console.WriteLine("I have dogs");
            //}
            //else if (haveCats)
            //{
            //    Console.WriteLine("I have cats");
            //} 
            //else if (haveIguana)
            //{
            //    Console.WriteLine("I have Iguana");
            //}
            //else
            //{
            //    Console.WriteLine("I have no pets");
            //}
            //Console.WriteLine("The End;");
            */


            // Switch Statements

            var input = "red";

            switch (input.ToLower())
            {
                case "green":
                    Console.WriteLine("Got here there");
                    break;
                case "red":
                    Console.WriteLine("Five gold rings");
                    break;
               
            }

            Console.ReadLine();
        }
    }
}
