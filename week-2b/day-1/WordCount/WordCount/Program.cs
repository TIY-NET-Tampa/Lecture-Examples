using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static public Dictionary<string, int> WordCount(string str)
        {
            var rv = new Dictionary<string, int>();
            var words = str.Split(' ');
            foreach (var word in words)
            {
                if (rv.ContainsKey(word))
                {
                    rv[word] += 1;
                }
                else
                {
                    rv.Add(word, 1);
                }

            }

            return rv;
        }


        static void Main(string[] args)
        {
            var jumboMumbo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pretium in est vel sagittis. Pellentesque pharetra, diam porttitor pulvinar finibus, justo libero malesuada enim, quis molestie nisi risus a odio. Ut id sem eget leo maximus sollicitudin. Curabitur vel consequat urna. In vulputate nulla vitae auctor facilisis. Vivamus fringilla, justo eu dignissim hendrerit, risus nisl sodales dui, a eleifend odio ante et purus. Maecenas tellus mi, ultricies ultricies mattis id, facilisis eget ex. Curabitur et elementum sem. Curabitur faucibus, odio in venenatis suscipit, elit libero volutpat lectus, tempor aliquam turpis erat a tellus. Curabitur dictum dapibus ullamcorper. Etiam faucibus nisl at vulputate blandit. Ut vel risus nisl. Suspendisse at euismod eros. Curabitur eget enim scelerisque quam eleifend tincidunt non et orci. Integer at ipsum eget turpis posuere rutrum. Aenean a ultrices nunc.";

            var testingString = "the cat jumps over the cat box";

            var counted = WordCount(jumboMumbo);

            var numbs = new List<int> { 4, 2, 6, 8, 5, 3, 2, 4, 7, 9, 0 };
            var sortedNums = numbs.OrderBy(o => { return o; }).ThenBy(t => { return t + 1});


            var sorted = counted
                .OrderByDescending(
                o => {
                    return o.Value;
                });

            foreach (var word in sorted)
            {
                Console.WriteLine($"{word}");
            }

            Console.ReadLine();
        }
    }
}
