using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousObjects
{
    public class Person
    {
        public string Name { get;  set; }

        public int Height { get; set; }

        public string Color { get; set; }

        private int phoneNumber;
        public string PhoneNumber
        {
            get {
                return phoneNumber.ToString(); }
            set {
                phoneNumber = int.Parse(value.Replace("-", ""));
            }
        }

        public string SayHelloTo(string someone)
        {
            return $"Hello, {someone}";
        }
        private int peopleKnown = 0;
        public string IntroduceMyself(string someone)
        {
            this.peopleKnown += 1;
            return $"Hello, {someone}, My name is {this.Name}";
        }

    }
}
