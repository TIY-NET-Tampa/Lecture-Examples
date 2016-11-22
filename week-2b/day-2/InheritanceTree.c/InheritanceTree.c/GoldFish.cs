using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    public class GoldFish:Fish
    {
        public bool IsDomestic { get; set; }
        //public new bool HasColdBlood { get; set; }

        public GoldFish(int gillCount):base(gillCount)
        {
            this.SaltWater = false;
            Console.WriteLine("Creating a goldfish");

            
            //this.HasColdBlood = false;
        }

        public override void Swim()
        {
            Console.WriteLine("Swimming in my bowl");
        }
    }
}
