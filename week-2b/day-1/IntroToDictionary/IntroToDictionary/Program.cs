using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(5);


            var x = list[0];
            var y = list.First();

            var dict = new Dictionary<string, int>();

            dict.Add("mark", 4);
            dict.Add("Sherry", 5);
            dict.Add("John", 2);

            var a = dict["mark"];

            // var c = dict["john"]
            var shouldBeTrue = dict.ContainsKey("John");
            var shouldBeFalse = dict.ContainsKey("john");

            if (dict.ContainsKey("Peter"))
            {
                dict["Peter"] += 1;
            }
            else
            {
                dict.Add("Peter", 0);
            }
        }
    }
}
