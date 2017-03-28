using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_FakeBinary
{

    public class Kata
    {
        public static string FakeBin(string x)
        {
            var rv = String.Empty; // == "" ;
            // we are looping
            for (int i = 0; i < x.Length; i++)
            {
                if( int.Parse(x[i].ToString()) >= 5)
                {
                    rv += "1";
                } 
                //else < 5
                else
                {
                    rv += "0";
                }
            }
            return rv;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Kata.FakeBin("45385593107843568"));
        }
    }
}
