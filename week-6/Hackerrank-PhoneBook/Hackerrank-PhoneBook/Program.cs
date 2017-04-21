using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = int.Parse(Console.ReadLine());
            var phonebook = new Dictionary<string, string>();
            for (int i = 0; i < total; i++)
            {
                var data = Console.ReadLine().Split(' ');
                phonebook.Add(data[0], data[1]);
            }

            var stillReading = true;
            var names = new List<string>();
            do
            {
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    stillReading = false;
                }
                else
                {
                    names.Add(input);
                }
            } while (stillReading);

            // check to see if the anemaare in the dict
            foreach (var item in names)
            {
                // check if item is in dictionaryu
                if (phonebook.ContainsKey(item))
                {
                    Console.WriteLine($"{item}={phonebook[item]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}















//var total = int.Parse(Console.ReadLine());
//var phoneBook = new Dictionary<string, int>();
//            for (int i = 0; i<total; i++)
//            {
//                var data = Console.ReadLine().Split(' ');
//phoneBook.Add(data[0], int.Parse(data[1]));
//            }

//            var names = new List<string>();
//var stillReading = true;
//var answers = new List<string>();
//            do
//            {
//                var input = Console.ReadLine();
//                if (String.IsNullOrEmpty(input))
//                {
//                    stillReading = false;
//                }
//                else
//                {
//                    names.Add(input);
//                }
//            } while (stillReading);


//            var output = names.Select(s => phoneBook.ContainsKey(s) ? $"{s}={phoneBook[s]}" : $"Not found").ToList();

//output.ForEach(Console.WriteLine);
