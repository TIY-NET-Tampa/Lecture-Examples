using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var favoriteColor = Colors.BLUE;

            //Console.WriteLine("what is your favorite color");
            //var input = Console.ReadLine();
            //var color = Enum.Parse(typeof(Colors), input);

            var bestSuit = Suits.SPADES;
            var counter = 0;

            bestSuit = Suits.HEARTS;

            if (bestSuit != Suits.SPADES)
            {
                Console.WriteLine("Weeee woo");
            }

            var kingOfhearts = new Card
            {
                ThisRank = Rank.KING,
                ThisSuit = Suits.HEARTS
            };

            Console.WriteLine(kingOfhearts);


            Console.WriteLine($"Your card is the {kingOfhearts.ThisRank} of {kingOfhearts.ThisSuit}");

            var myHand = new List<Card>();

            myHand.Add(new Card { ThisSuit = Suits.SPADES, ThisRank = Rank.ACE });

            myHand.Add(new Card { ThisSuit = Suits.SPADES, ThisRank = Rank.KING });

            myHand.Add(new Card { ThisSuit = Suits.SPADES, ThisRank = Rank.QUEEN });

            myHand.Add(new Card { ThisSuit = Suits.SPADES, ThisRank = Rank.JACK });

            myHand.Add(kingOfhearts);

            Console.WriteLine("Your hand is:");
            foreach (var card in myHand)
            {
                Console.WriteLine(card);
            }


        }
    }
}
