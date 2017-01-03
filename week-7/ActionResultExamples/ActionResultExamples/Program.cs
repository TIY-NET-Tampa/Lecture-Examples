using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionResultExamples
{
    class Program
    {

        public static int DoMath(Func<int,int,int> method, int x, int y)
        {
            return method(x, y);
        }

        static void Main(string[] args)
        {
            Action<string> print = s => Console.WriteLine(s);
            print("hellow world");

            Func<int, int, int> add = (x, y) => x + y;

            print(add(2, 3).ToString());

            print(DoMath(add, 5, 6).ToString());

            Console.ReadLine();
        }
    }
}
