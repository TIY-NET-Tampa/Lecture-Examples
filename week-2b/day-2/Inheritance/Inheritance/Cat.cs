using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat :Pet, ISpeakable
    {
        public bool IsPurring { get; set; }

        public string Growl()
        {
            return "hissssssssss";
        }

        public string Speak()
        {
            return "Meow";
        }
    }
}
