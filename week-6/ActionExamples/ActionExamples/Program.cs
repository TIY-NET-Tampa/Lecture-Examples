using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<int, int> Add = (x, y) =>  x + y; 
        }
    }
}
