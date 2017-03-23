using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static Dictionary<string, int> AddToPhoneBook(Dictionary<string, int> phoneBook, string name, int number)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine("Already have their number");
            }
            else
            {
                phoneBook.Add(name, number);
            }
            return phoneBook;
        }

        static void DisplayDictionary(Dictionary<string, int> dict)
        {
            foreach (var name  in dict.Keys)
            {
                Console.WriteLine($"{name} - {dict[name]}");
            }
        }

        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, int>();

            phoneBook.Add("name", 1231231234);
            phoneBook.Add("Jenny", 8675309);

            Console.WriteLine($"Her number is: {phoneBook["Jenny"]}");

            Console.WriteLine("What is their name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is their number?");
            var numAsString = Console.ReadLine();
            int.TryParse(numAsString, out int phoneNumber);

            phoneBook = AddToPhoneBook(phoneBook, name, phoneNumber);

            DisplayDictionary(phoneBook);


            Console.WriteLine("----------");

            foreach(var pn in phoneBook.Values)
            {
                Console.WriteLine($"{pn}");
            }
        }
    }
}
