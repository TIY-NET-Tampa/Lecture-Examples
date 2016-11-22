using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog : Pet,ISpeakable
    {   public bool isTailWaggin { get; set; }

        public string Speak()
        {
            return "Bark!";
        }

        public string Growl()
        {
            return "Grrrr";
        }

        public Dog()
        {
            this.Name = "Fido";
        }

    }
}
