using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionarys
{
    class Program
    {

        class Player
        {
            public string Name { get; set; }
            public int JerseyNumber { get; set; }
            public string Sandwich { get; set; }
        }

        static void Main(string[] args)
        {

            var myArrry = new int[5];
            var myOtherArray = new int[] { 1, 2, 3, 4, 5 };
            // def: var myVarible = new List<type>();

            var myList = new List<string>();
            var myOtherList = new List<double>() { 1.0, 1.2, 2.2, 3.3 };

            myList.Add("4");
            myList.Add("5");
            myList.Add("hello");

            var greeting = myList[2];
            myList[1] = "not 5";

            // we want to "hello"
            var needle = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == "hello")
                {
                    needle = i;
                }

            }

            myList.RemoveAt(2);
            myList.Remove("4");

            var birthdays = new List<DateTime>();

            birthdays.Add(new DateTime(1988, 12, 12));


            // does the index change when we remove an item

            var names = new List<string>()
            {
                "Bill","Jill", "Jim","Leigh", "Jim James", "Jim"
            };

            names.Remove("Jim");
            var noJims = names.Where(name => name != "Jim");
            names.Add("Not Jim");


            var teamRoster = new Dictionary<string, Player>();

            teamRoster.Add("jimmy", new Player
            {
                JerseyNumber = 66,
                Name = " Jimmy",
                Sandwich = "PB& J"
            });
            //teamRoster.Add("johns", 88);
            //teamRoster.Add("betty", 14);
            //teamRoster.Add("Sam", 99);

            var jimmy = teamRoster["jimmy"];

            var favoriteSandwich = jimmy.Sandwich;
            var jimNum = jimmy.JerseyNumber;

           // var bill = teamRoster["bill"]; // throw an error & crash

            var player = new Player();
            var wasInside = teamRoster.TryGetValue("bill", out player);


            if (teamRoster.ContainsKey("bill"))
            {
                teamRoster["bill"] = new Player();
            }
            else
            {
                teamRoster.Add("bill", new Player());
            }


            // count 

            var counts = new Dictionary<char, int>();

            var sentence = "Big Brown Fox Jumped Over the Moon";

            foreach (var character in sentence)
            {
                if (counts.ContainsKey(character))
                {
                    counts[character] += 1 ;
                }
                else
                {
                    counts.Add(character, 1);
                }
            }



        }
    }
}
