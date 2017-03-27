using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public class Card { }
        static public List<Card> deck = new List<Card>();
        static List<Card> HitOrStayPromptAndUserInput(List<Card> hand)
        {
            Console.WriteLine("Enter (H) to HIT or Enter (S) to STAY.");
            var result = Console.ReadLine();
            while (result != "H" && result != "S")
            {
                Console.WriteLine("I said Enter (S) or (H)");
                result = Console.ReadLine();
            }
            if (result == "H")
            {
                deck.RemoveAt(0);
                hand.Add(deck[0]);
                return hand;
            }
            else
            {
                return hand;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
