using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToFiles
{
    class Program
    {

        class Contact
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public override string ToString()
            {
                return $"{Name},{Email},{PhoneNumber}";
            }
            public Contact()
            {

            }
            public Contact(string[] data)
            {
                Name = data[0];
                Email = data[1];
                PhoneNumber = data[2];

            }
        }

        static void Main(string[] args)
        {

            var path = "test.txt";

            var output = "Hello world, this is actually working";

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(output);
            }
            using (var reader = new StreamReader(path))
            {
                var text = "";
                while (reader.Peek() >= 0)
                {
                    text += reader.ReadLine();
                }
            }


            //var bill = new Contact() { Email = "b@gmail.com", Name = "Bill", PhoneNumber = "123,123,1234" };

            //var jenny = new Contact() { Email = "j@gmail.com", Name = "Jenny", PhoneNumber = "123-865-7309" };

            //var susan = new Contact() { Email = "s@gmail.com", Name = "Susan", PhoneNumber = "555.555.5555" };

            //var phoneBook = new List<Contact> { bill, jenny, susan };

            //foreach (var person in phoneBook)
            //{
            //    Console.WriteLine(person);
            //}

            //using (var writer = new StreamWriter(phoneBookPath))
            //{
            //    foreach (var person in phoneBook)
            //    {
            //        writer.WriteLine(person);
            //    }
            //}

            var phoneBookPath = "phoneBook.csv";
            var myPhoneBook = new List<Contact>();
            // want to read my phone book back into memory
            using (var reader = new StreamReader(phoneBookPath))
            {
                while (reader.Peek() > -1)
                {
                    var person = reader.ReadLine();
                    var split = person.Split(',');
                    var contact = new Contact(split);
                    myPhoneBook.Add(contact);

                }
            }
            foreach (var contact in myPhoneBook)
            {
                Console.WriteLine(contact);
            }



            var writer = new StreamWriter(phoneBookPath);
            writer.WriteLine("Hello");
            // so much more code , which could crash
            writer.Close();
        }
    }
}
