using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_Ceaser
{
    class Program
    {
        public static char GetNextCharacter(char c)
        {
            if (c == 'z')
                return 'a';
            else if (c == 'Z')
                return 'A';
            else
                return (char)(c + (char)1);
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            var output = String.Join("", str.Select(letter =>
            {
                var temp = letter;
                  // offset that by k
                if (char.IsLetter(temp))
                {
                    for (int i = 0; i < k; i++)
                    {
                        temp = GetNextCharacter(temp);
                    }
                }
                return temp;
            }));
            Console.WriteLine(output);

        }
    }
}












//int n = Convert.ToInt32(Console.ReadLine());
//string str = Console.ReadLine();
//int k = Convert.ToInt32(Console.ReadLine());

//var output = String.Join(String.Empty, str.Select(letter => {
//    var temp = letter;
//    if (char.IsLetterOrDigit(temp))
//    {
//        for (int i = 0; i < k; i++)
//        {
//            temp = GetNextCharacter(temp);
//        }
//    }
//    return temp;
//}));

//Console.WriteLine(output);



//int n = Convert.ToInt32(Console.ReadLine());
//string str = Console.ReadLine();
//int k = Convert.ToInt32(Console.ReadLine());
//var output = String.Join(String.Empty, str.Select(s => char.IsLetterOrDigit(s) ? (char)(s + (char)k) : s));
//Console.WriteLine(output);