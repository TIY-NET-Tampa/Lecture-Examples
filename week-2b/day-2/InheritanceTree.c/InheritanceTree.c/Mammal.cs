using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    public abstract class Mammal:Creature
    {
        public string HairColor { get; set; }
        public bool HasWarmBlood { get; } = true;
        public bool HasSpine { get; } = true;
   
        public Mammal()
        {
           
        }
    }
}
