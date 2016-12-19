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


            var toDelete = db.Customers.Where(f => f.Name == "Hoss");
            db.Customers.RemoveRange(toDelete);
            db.SaveChanges();


            var allCustomers3 = db.Customers.ToList();

            PrintCollection("All cusotmers -- deleted", allCustomers3);


            Console.ReadLine();

        }
    }
}
