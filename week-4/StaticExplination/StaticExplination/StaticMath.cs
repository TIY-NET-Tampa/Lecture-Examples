using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExplination
{
    public static class StaticMath
    {
        public static int RunningTotal { get; set; }

        public static void AddToRunningTotal(int num)
        {
            RunningTotal += num;
        }
    }
}
