using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorFun
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Calling the constructor

            //var parent = new Parent("Paul");
            //var p1 = new Parent("Paul");

            //var p2 = new Parent("Paul");
            //var p3 = new Parent("Paul");

            //var myList = new List<Parent>();
            //for (int i = 0; i < 10; i++)
            //{
            //    var par = new Parent(i.ToString());
            //    myList.Add(par);
            //}

            // Calls the constucrot of the parent on the base
            var child = new Child();

            Console.ReadLine();
        }
    }
}
