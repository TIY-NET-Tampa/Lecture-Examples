using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview__HumansPandasRobots
{
    abstract class LivingThing : Being
    {
        public bool IsAsleep { get; set; }

        public virtual void GoToSleep()
        {
            this.IsAsleep = true;
        }
        public void WakeUp()
        {
            this.IsAsleep = false;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Yum, I ate {food}");
        }
    }
}
