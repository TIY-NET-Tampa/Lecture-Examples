using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    public abstract class Fish:Creature
    {
        public int GillCount { get; set; }
        public bool HasColdBlood { get; set; } = true;
        public string FinType { get; set; }

        public bool SaltWater { get; set; } = true;
        public Fish(int GillCount)
        {
            Console.WriteLine($"Creating a Fish with {GillCount} Gills");
            this.GillCount = GillCount;
        }

        public void Swim()
        {
            Console.WriteLine("Just keep swimming");
        }
    }
}
