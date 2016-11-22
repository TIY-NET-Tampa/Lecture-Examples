using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    public class Shark : Fish
    {
        public Shark():base(10)
        {
            this.SaltWater = true;
        }
    }
}
