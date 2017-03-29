using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview__HumansPandasRobots
{
    interface IGreeter
    {
        string Name { get; set; }
        void DisplayGreeting();
    }
}
