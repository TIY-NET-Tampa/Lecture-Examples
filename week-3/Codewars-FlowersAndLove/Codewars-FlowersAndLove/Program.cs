using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_FlowersAndLove
{
    public class LoveDetector
    {
        /*f one of the flowers has an even number of petals 
         * and the other has an odd number of petals it means 
         * they are in love.*/
        public static bool lovefunc(int flower1, int flower2)
        {
            return ((flower1 % 2 == 0) != (flower2 % 2 == 0));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

             var shouldBeTrue = LoveDetector.lovefunc(10, 11);
            var shouldBeFalse = LoveDetector.lovefunc(9, 9);
            var shouldAlsoFalse = LoveDetector.lovefunc(12, 12);




        }
    }
}
