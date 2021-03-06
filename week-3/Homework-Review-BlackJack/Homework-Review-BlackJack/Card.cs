﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Review_BlackJack
{
    public class Card
    {
        public Suit ThisSuit { get; set; }
        public Rank ThisRank { get; set; }
        public int CardNumber { get; set; }

        public Card(Suit s, Rank r)
        {
            this.ThisSuit = s;
            this.ThisRank = r;
        }

        public int GetCardValue()
        {
            var rv = 0;
            switch (this.ThisRank)
            {
                case Rank.Ace:
                    rv = 11;

                    break;
                case Rank.Deuce:
                    rv = 2;
                    break;
                case Rank.Three:
                    rv = 3;
                    break;
                case Rank.Four:
                    rv = 4;
                    break;
                case Rank.Five:
                    rv = 5;
                    break;
                case Rank.Six:
                    rv = 6;
                    break;
                case Rank.Seven:
                    rv = 7;
                    break;
                case Rank.Eight:
                    rv = 8;
                    break;
                case Rank.Nine:
                    rv = 9;
                    break;
                case Rank.Ten:
                    rv = 10;
                    break;
                case Rank.Jack:
                    rv = 10;
                    break;
                case Rank.Queen:
                    rv = 10;
                    break;
                case Rank.King:
                    rv = 10;
                    break;
                default:
                    break;
            }
            return rv;
        }



        public override string ToString()
        {
            return $"The {this.ThisRank} of {this.ThisSuit}";
        }
    }

}
