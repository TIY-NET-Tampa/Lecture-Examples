using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {



            //var mark = new Person("linus");
            //mark.Age = 28;
            //mark.HairColor = "Brown";


            var otherMark = new Person("otherMark")
            {
                Age = 28,
                HairColor = "Brown",
                Height = 73
            };

            var spot = new Dog();
            spot.HairColor = "spotted";
            spot.Name = "Henry";

            spot.Speak();

            var charlie = new Iguana();


            var mrWhiskers = new Cat("Mr. Whiskers");

            otherMark.Pets.Add(spot);
            otherMark.Pets.Add(mrWhiskers);
            otherMark.Pets.Add(charlie);

            var dogPound = new List<Dog>();
            dogPound.Add(spot);

            var choir = new List<ISpeakable>
            {
                  spot, mrWhiskers, otherMark
            };

            foreach (var singer in choir)
            {
                singer.Speak();
            }


     


        }
    }
}
