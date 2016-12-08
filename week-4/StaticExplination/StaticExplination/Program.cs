using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StaticExplination
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not possible, since Staticmath is static, there can be only 1
            //var nope = new StaticMath();

            StaticMath.AddToRunningTotal(1);
            StaticMath.AddToRunningTotal(3);
            StaticMath.AddToRunningTotal(5);

            var value = StaticMath.RunningTotal;

            var yes = new NonStaticMath();
            var yeah = new NonStaticMath();
            var yaaa = new NonStaticMath();


            yes.AddToRunningTotal(5);
            yes.AddToRunningTotal(3);

            yeah.AddToRunningTotal(10);
            File.Create();


        }
    }
}
