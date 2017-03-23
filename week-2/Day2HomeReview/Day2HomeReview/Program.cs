using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2HomeReview.Logic;

namespace Day2HomeReview
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // generating a random Number
            var target = NumberGuesser.GenerateRandomNumber(1, 100);

            // game logic
            var counter = NumberGuesser.GameLoop(target);
            var outher = NumberGuesser.GameLoop(target);

            // EndCredits
            NumberGuesser.DisplayEndCredits(counter);

           
        }

    }
}
