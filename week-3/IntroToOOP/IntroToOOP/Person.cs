using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string HairColor { get; set; }

        private int _age;

        public int Age
        {
            set { _age = value; }
        }

        public bool CanDrink
        {
            get
            {
                return (this._age >= 21);
            }
        }

        public Person(string name)
        {
            Console.WriteLine("Creating a new Person");
            this.Name = name;
            this.SayGreeting();
        }


        public void SayGreeting()
        {
            Console.WriteLine( $"Hello, my name is : {this.Name}"); 
        }

    }
}
