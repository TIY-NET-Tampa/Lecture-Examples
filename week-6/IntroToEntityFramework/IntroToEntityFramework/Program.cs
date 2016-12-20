using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEntityFramework.Models;

namespace IntroToEntityFramework
{
    class Program
    {

        public static void PrintCollection(string heading, IEnumerable<Customer> list)
        {
            Console.WriteLine(heading);
            foreach (var customer in list)
            {
                Console.WriteLine(customer);
            }
        }

        static void Main(string[] args)
        {
            var db = new RentalContext();

            // SELECT * FROM Customers
            var customers = db.Customers.ToList();
            var notYet = db.Customers;


            // Reading
            PrintCollection("All Customers", customers);

            var activeCustomer = db.Customers.Where(w => w.IsActive);

            PrintCollection("Active Cusomters", activeCustomer);

            var longTimeCustomer = db.Customers.Where(w => w.YearJoined < 1900 && w.IsActive);

            PrintCollection("Long time customers", longTimeCustomer);


            // Creating

            var newCustomer = new Customer
            {
                Name = "Hoss",
                IsActive = true,
                YearJoined = 1988,
                RewardPoints = 1000
            };

            db.Customers.Add(newCustomer);

            db.SaveChanges();

            var allCustomers = db.Customers.ToList();

            PrintCollection("All cusotmers", allCustomers);

            //Updating 
            var itemToUpdate = db.Customers.First(f => f.Name == "Irwin");
            itemToUpdate.IsActive = false;
            itemToUpdate.RewardPoints += 100;
            db.SaveChanges();

            var allCustomers2 = db.Customers.ToList();

            PrintCollection("All cusotmers -- updated", allCustomers2);

            // Deleting
            var toDelete = db.Customers.Where(f => f.Name == "Hoss");
            db.Customers.RemoveRange(toDelete);
            db.SaveChanges();


            var allCustomers3 = db.Customers.ToList();

            PrintCollection("All cusotmers -- deleted", allCustomers3);


            var customer = db.Customers.First(f => f.Id == 1);

            customer.Address = new Address
            {
                AddressLine = "123 Fake",
                City = "NowwhereVille",
                State = " HA",
                Zip = "12345"
            };

            db.SaveChanges();


            /*
             SELECT Id, Name
             FROM CUSTOMERS
             WHERE IsActive = 1
             */

            var noJoin = db.Customers
                .Where(w => w.IsActive)
                .Select(s => new { s.Id, s.Name, s.IsActive });


            // Many to Many relationships

            var movie = new Movies
            {
                Name = "Back to the Future"
            };
            // db.Movies.Add(movie);
           // movie.Customers.Add(cus1);

            var cus1 = db.Customers.First(f => f.Id == 2);
            cus1.Movies.Add(movie);
            db.SaveChanges();
            
            

            Console.ReadLine();

        }
    }
}
