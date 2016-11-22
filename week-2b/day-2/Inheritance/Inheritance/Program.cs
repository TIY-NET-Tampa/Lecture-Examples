using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var fido = new Dog();
            var linda = new Cat();

            var myPets = new List<Pet>();

            myPets.Add(fido);
            myPets.Add(linda);

            var choir = new List<ISpeakable>();
            choir.Add(linda);
            choir.Add(fido);
            choir.Add(new Person { Name = "Jimmy" });

            foreach (var item in choir)
            {
                Console.WriteLine(item.Speak());
            }

            Console.ReadLine();

        }
    }
}
