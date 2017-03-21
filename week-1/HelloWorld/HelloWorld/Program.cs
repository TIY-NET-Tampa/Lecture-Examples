using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Wlecome to class");

            // Varilble is a value that I store in my program (memory), 
            // that I want to use over and over again

            // store the value 5 in a varible
            int anythingIWant = 5;





            float someNumber = 5.4f;
            double myDouble = 5.3d;


            // use this
            decimal myDec = 5.2m;


            char letter = 'w';

            int answerToTheMeaningOfLife = 42;
            int answer_to_the_meaning_of_life = 42;

            int answer = answerToTheMeaningOfLife;

            bool trusish = true;

            string sentence = "See Spot Run!";


            Console.Write("Hello");
            Console.Write(" World");

            Console.WriteLine(answerToTheMeaningOfLife);
            Console.WriteLine(myDec);
            var sum = 5 + 4;

            Console.WriteLine("Enter your favorite Color");
            string favColor = Console.ReadLine();
            string output = "Your favorite color is " + favColor;
            string formater = String.Format("Your real favorite color is {0}", favColor);
            string favoriteFoods = String.Format("My Favorite foods are {1}, {0} and {2} and the total is {3:C}", "sushi", "wings", "pizza", 4.5);
            string finalVersion = $"Your actual favorite color is {favColor}";

            int count = 0;

            count += 5;

            string startingString = "My Favorite color is ";
            startingString += "green";


            Console.WriteLine(favoriteFoods);
            Console.WriteLine(output);

            // Type system


            int numberOfStudents = 11;
            string clasName = ".NET";
            string total = numberOfStudents.ToString() + clasName;

            DateTime today = DateTime.Now;



            DateTime nextWeek = today.AddDays(5);


            Console.WriteLine("How much do you want to donate to charity");
            string rawInput = Console.ReadLine();
            Decimal value = 0;
            bool wasFormatedCorrectly = Decimal.TryParse(rawInput, out value);
            if (wasFormatedCorrectly)
            {
                Console.WriteLine($"you are actually donating {value:C}");
            }
            else
            {
                Console.WriteLine("Sorry, that was a bad format.");
            }


            // var!

          //  int num = 10;

            var alsoTen = DateTime.Now;

            var myFloat = 10.4;


            int num = int.Parse(Console.ReadLine());

        }



    }
}
