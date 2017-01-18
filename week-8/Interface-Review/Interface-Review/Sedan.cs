using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{
    class Sedan : IHasOil
    {
        public void ChangeOil()
        {
            Console.WriteLine("Changin Oil for Sedan");
        }
    }
}
