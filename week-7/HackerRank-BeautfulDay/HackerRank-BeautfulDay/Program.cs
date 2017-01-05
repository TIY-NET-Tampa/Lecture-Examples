using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_BeautfulDay
{
    class Program
    {

        public class Car
        {
            public string Color { get; set; }
        }

        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            var i = data[0];
            var j = data[1];
            var k = data[2];


            var beautifulDays = 0;

            for (int day = i; day <= j; day++)
            {
                // QUESTION: when to use new vs not use to new
                // High level  creation vs using 

                // NOPE
                //var math1 = new Math();

                var ans = Math.Cos(10);

                var myCar = new Car
                {
                    Color = "Blue"
                };


                // bool, int, doulble, string
                // Bool, Int, Double, String

                string x = "High Five";
                String y = "High Five";
                var ch = new char[] { 'h', 'i', 'g' };
                var z = new String("high five".ToCharArray());

                var reverse = int.Parse(new String(day.ToString().Reverse().ToArray()));
                var answer = Math.Abs((double)day - (double)reverse) / (double)k;
                if (answer == Math.Floor(answer))
                {
                    beautifulDays++;
                }

            }
            Console.WriteLine(beautifulDays);
            Console.ReadLine();
        }
    }
}
