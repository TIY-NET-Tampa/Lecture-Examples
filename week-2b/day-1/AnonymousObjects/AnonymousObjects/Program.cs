using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // person has a name
            // person has a favorite color
            // person has a height

            var person1Name = "Justin";
            var person1Color = "blue";
            var person1Height = 75;

            var person = new
            {
                Name = "Justin",
                Color = "blue", 
                Height= 75
            };
            
            Console.WriteLine($"{person.Name} likes {person.Color} and is {person.Height} inches tall");

            var realBoy = new Person();
            realBoy.PhoneNumber = "867-5309";

            realBoy.Name = "Pinocihio";

            Console.WriteLine($"{realBoy.Name}, call him at {realBoy.PhoneNumber}");


            var bill = new Person() {
                Name = "Billy",
                Color = "red",
                Height = 54
            };

            var ted = new Person()
            {
                Name = "teddy",
                Color = "blue",
                Height = 64
            };


            var myDict = new Dictionary<int, Person>();

            myDict.Add(10, realBoy);
            myDict.Add(23, bill);
            myDict.Add(3, ted);

            Console.WriteLine($"I am going on an adventure with {myDict[23].Name}");

            Console.WriteLine(realBoy.IntroduceMyself("Jimmy"));
            Console.WriteLine(bill.IntroduceMyself("Jimmy"));
            Console.WriteLine(ted.IntroduceMyself("Jimmy"));

            Console.ReadLine();
        }
    }
}
