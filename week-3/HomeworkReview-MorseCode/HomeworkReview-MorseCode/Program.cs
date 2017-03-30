using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview_MorseCode
{
    /*
     x Writing to document
     x quick overview of using
     - what classes would help?
     - how i would go the other way, alpha -> morse, morse -> alpha
            - reuploading the dictionary?
            - GEtValue vs Querying
         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a phrase");
            var input = Console.ReadLine().ToUpper();

            // you want to be this
            var morseCodeTranslator = new MorseCodeTranslator();
            var translated = morseCodeTranslator.TranslateEnglishToMorse(input);

            Console.WriteLine($"{input} -> {translated}");

            Console.WriteLine($"{morseCodeTranslator.TranslateMorseToEnglish("...,---,...")}");

            
            morseCodeTranslator.SaveTranslationToFile(input, translated);
        }




    }
}
