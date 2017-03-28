using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Person : ISpeakable
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string HairColor { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

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
            this.Speak();
        }

        public void Speak()
        {
            Console.WriteLine( $"Hello, my name is : {this.Name}"); 
        }



    }
}
