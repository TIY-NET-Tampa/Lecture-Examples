using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_time_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();

            var twelve = DateTime.Parse(time);
            Console.WriteLine(twelve.ToString("HH:mm:ss"));



            var splited = time.Split(':');

            var isMorning = time.Contains("AM");

            var hour = int.Parse(splited[0]);
            if (isMorning && hour == 12)
            {
                hour = 0;
            }
            
            else if (!isMorning && hour != 12)
            {
                hour += 12;
            }


            var mins = splited[1];
            var sec = splited[2].Substring(0, 2);



            Console.WriteLine($"{hour:00}:{mins:00}:{sec:00}");


            sec = sec.TrimEnd()


        }
    }
}
