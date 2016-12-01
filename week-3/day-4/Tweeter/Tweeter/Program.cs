using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweeter
{
    class Program
    {
        static string tweeter(string text)
        {
            var maps = text.Replace("naps", "maps");
            return maps;
        }
        public static void Main()
        {
            Console.WriteLine(tweeter("I really like naps") == "I really like maps");
            Console.WriteLine(tweeter("naps maps naps maps") == "maps maps maps maps");
        }
    }
}