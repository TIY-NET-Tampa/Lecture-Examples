using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExplination
{
    public class NonStaticMath
    {
        public int RunningTotal { get; set; }

        public void AddToRunningTotal(int num)
        {
            RunningTotal += num;
        }
    }
}
