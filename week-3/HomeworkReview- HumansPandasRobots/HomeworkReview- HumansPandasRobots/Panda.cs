using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview__HumansPandasRobots
{
    class Panda : LivingThing, IGreeter
    {
        public void DisplayGreeting()
        {
            Console.WriteLine("**Panda Noises****");
        }

        public override void GoToSleep()
        {
            Console.WriteLine("Go to nest");
            base.GoToSleep();
        }

        public static Panda operator +(Panda mom, Panda dad)
        {
            return new Panda() { Name = mom.Name +" -- " +dad.Name };
        }
    }
}
