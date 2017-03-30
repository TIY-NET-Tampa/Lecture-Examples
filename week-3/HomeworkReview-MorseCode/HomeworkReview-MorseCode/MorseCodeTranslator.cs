using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview_MorseCode
{

    //class TranslationBit
    //{
    //    public char Key { get; set; }
    //    public string Value { get; set; }
    //}

    class MorseCodeTranslator
    {
        public Dictionary<char, string> TranslationKey { get; set; } = new Dictionary<char, string>();
        public Dictionary<string, char> MorseCode { get; set; } = new Dictionary<string, char>();
        private const string dictionaryPath = "morse.csv";
        private const string outputFile = "output.csv";


        public MorseCodeTranslator()
        {
            this.PopulateDictionary();
        }

        public void PopulateDictionary()
        {
            using (var reader = new StreamReader(dictionaryPath))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine().Split(',');
                    this.TranslationKey.Add(char.Parse(line[0]), line[1]);
                    this.MorseCode.Add(line[1], char.Parse(line[0]));
                }
            }
        }
        public string TranslateEnglishToMorse(string input)
        {
            var translated = String.Empty;
            foreach (var letter in input)
            {
                if (this.TranslationKey.ContainsKey(letter))
                {
                    translated += this.TranslationKey[letter];
                }
                else
                {
                    translated += letter;
                }
            }
            return translated;
        }

        // input is a comma delimiter of morse code -> ...,---,...
        public string TranslateMorseToEnglish(string input)
        {
            var morseCodes = input.Split(',');
            var rv = String.Empty;
            foreach (var letter in morseCodes)
            {
                if (this.MorseCode.ContainsKey(letter))
                {
                 rv += this.MorseCode[letter];

                }
                else
                {
                    rv += letter;
                }
            }
            return rv;
        }

        public void SaveTranslationToFile(string input, string translated)
        {
            using (var writer = new StreamWriter(outputFile, true))
            {
                writer.WriteLine($"{input}, {translated}");
            }
        }
    }
}
