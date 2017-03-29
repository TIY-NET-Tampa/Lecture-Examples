using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Jaden
{

    

    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {

            // cutting out spaces
            // doing a toUpper
            // then putting it back together

            var splitted = phrase.Split(' ');
            var newString = String.Empty;

            foreach (var word in splitted)
            {
                newString += (word[0].ToString().ToUpper()) + word.Substring(1) + " ";
            }

            //  "      helloe world        ".Trim() == "helloe world"
            return newString.Trim();


            //var newString = String.Empty;
            //for (int i = 0; i < phrase.Length; i++)
            //{
            //    var currentChar = phrase[i];
            //    if ((i > 0 && phrase[i - 1] == ' ') || i == 0)
            //    {
            //        currentChar = char.Parse(phrase[i].ToString().ToUpper());
            //    }
            //    newString += currentChar;               
            //}
            //return newString;
        }
    }
    class Program
    {
        static public int Add(int x, int y)
        {
            return x + y;
        }

        static public int Add(int x, int y, int z)
        {
            return x + y + z;
        }


        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1, 2, 3);
            Console.WriteLine("lets try it out".ToJadenCase());
        }
    }
}
