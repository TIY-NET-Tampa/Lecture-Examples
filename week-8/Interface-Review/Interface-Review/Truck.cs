using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{
    class Truck : IHasOil
    {
        public void ChangeOil()
        {
            Console.WriteLine("Changing the Oirl for the Truck");
        }
    }
}
