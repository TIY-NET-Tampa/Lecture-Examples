using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Logic
    {
        // Add
        public static int Add(int a, int b)
        {
            var rv = a + b;
            return rv;
        }
        // Subtract
        public static int Subtract(int a, int b)
        {
            var rv = a - b;
            return rv;
        }
        // Multiple
        public static int Multiply(int a, int b)
        {
            var rv = a * b;
            return rv;
        }
        // Division
        public static int Division(int a, int b)
        {
            var rv = a / b;
            return rv;
        }
    }
}
