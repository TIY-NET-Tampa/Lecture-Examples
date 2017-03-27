using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Questions: 
    X switch ?
    X how does GetCardValue work? 
    X how does the randomizer work? 
    X How to call an Enum that is attached to a class
    X How to access methods in other classes that not in your program.cs
    - see gernalize version of the loop/method of the hit logic
     */

namespace Homework_Review_BlackJack
{
    class Program
    {
        static List<Card> RandomDeck = new List<Card>();

        static List<Card> AddCardTo(List<Card> hand)
        {
            hand.Add(RandomDeck[0]);
            RandomDeck.RemoveAt(0);
            return hand;
        }

        static void DisplayHand(IEnumerable<Card> hand)
        {
            foreach (var card in hand)
            {
                Console.WriteLine(card);
            }
        }

        static int GetHandTotal(List<Card> hand)
        {
            var total = 0;
            foreach (var card in hand)
            {
                total += card.GetCardValue();
            }
            return total;
        }

        static void DisplayHandTotal(List<Card> hand)
        {
            var total = GetHandTotal(hand);
            Console.WriteLine($"Your total is : {total}");
        }

        static void Main(string[] args)
        {

            // Explaination of a switch
            //var count = 5;
            //for (int i = count; i >= 0; i--)
            //{
            //    switch (i)
            //    {
            //        case 5:
            //            Console.WriteLine("Five!");
            //            break;
            //        case 3:
            //            Console.WriteLine("Three!");
            //            break;
            //        case 4:
            //            Console.WriteLine("Four!");
            //            break;
            //        case 2:
            //            Console.WriteLine("Two!");
            //            break;
            //        case 1:
            //            Console.WriteLine("One!");
            //            break;
            //        default:
            //            Console.WriteLine("BlastOff!!!");
            //            break;

            //    }
            //}
            var deck = new List<Card>();

            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    deck.Add(new Card(s, r));
                }
            }

            //sort the deck. NOTICE that the variable 'deck' is unchanged, but 'randomDeck' is the actual sorted deck.
            RandomDeck = deck.OrderBy(x => Guid.NewGuid()).ToList();

            var playerHand = new List<Card>();
            var dealerHand = new List<Card>();

            playerHand = AddCardTo(playerHand);
            playerHand = AddCardTo(playerHand);
            dealerHand = AddCardTo(dealerHand);
            dealerHand = AddCardTo(dealerHand);

            DisplayHand(new Card[9]);


            DisplayHand(dealerHand.Take(1));
       

            var stillPlaying = true;
            while (stillPlaying && GetHandTotal(playerHand) <= 21)
            {
                Console.WriteLine("Your Hand:");
                DisplayHand(playerHand);
                DisplayHandTotal(playerHand);
                Console.WriteLine();
                Console.WriteLine("[H]it or [S]tay?");
                var input = Console.ReadLine();
                if (input.ToLower() == "h")
                {
                    playerHand = AddCardTo(playerHand);
                }
                else if (input.ToLower() == "s")
                {
                    stillPlaying = false;
                }
            }
            
            Console.WriteLine($"You are done playing with a {GetHandTotal(playerHand)}");

            Console.WriteLine("Dealers Turn");
            DisplayHand(dealerHand);
            DisplayHandTotal(dealerHand);
            while(GetHandTotal(dealerHand) < 16)
            {
                dealerHand = AddCardTo(dealerHand);
                Console.WriteLine("Dealers New Hand:");
                DisplayHand(dealerHand);
            }
            Console.WriteLine();


            Console.WriteLine($"Dealer has {GetHandTotal(dealerHand)}");

            Console.WriteLine($"Player has {GetHandTotal(playerHand)}");

        }
    }
}
