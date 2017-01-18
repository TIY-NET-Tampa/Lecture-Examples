using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{
    class Bicycle : IHasTires
    {
        public void ChangeTires()
        {
            Console.WriteLine("Changing my bike tires");
        }
    }
}
