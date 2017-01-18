using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{
    class RaceCar : IHasOil, IFillUpAble, IHasTires
    {
        public void ChangeOil()
        {
            Console.WriteLine("Changing Oil for my Racecar");
        }

        public void ChangeTires()
        {
            Console.WriteLine("Changing my tires for a racecar");
        }

        public void FillUp()
        {
            Console.WriteLine("Filling up my Race car");
        }
    }
}
