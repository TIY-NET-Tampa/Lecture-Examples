using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var pete = new GoldFish(2);
            var koi = new GoldFish(6);
            var shark = new Shark();
            var bruce = new Shark();

            pete.Swim();
            pete.Swim();
            pete.Swim();
            pete.Swim();
            pete.Swim();
            pete.Swim();

            Console.ReadLine();
        }
    }
}
