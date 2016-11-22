using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person : ISpeakable
    {
        public string Name { get; set; }
        public bool WearsBelts { get; set; }

        public string Growl()
        {
            return "No No no";
        }

        public string Speak()
        {
            return "Hello There!!!!";
        }
    }
}
