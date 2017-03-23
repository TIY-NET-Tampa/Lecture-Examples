using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public class Card
    {
        public Suits ThisSuit { get; set; }
        public Rank ThisRank { get; set; }
        public override string ToString()
        {
            return $"{ThisRank} of {ThisSuit}";
        }
    }
}
