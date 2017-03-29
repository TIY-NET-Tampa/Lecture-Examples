using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview__HumansPandasRobots
{
    class Robot : Being, IGreeter
    {
        public void DisplayGreeting()
        {
            Console.WriteLine($"Beep Boop, I am a {this.GetType().Name}");
        }
    }
}
