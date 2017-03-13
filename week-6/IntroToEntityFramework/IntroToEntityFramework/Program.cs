using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEntityFramework.Models;
using System.Data.Entity;

namespace IntroToEntityFramework
{
    class Program
    {
        // Print Out a collection
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

            // SELECT * FROM Customers WHERE IsActive = True
            var activeCustomer = db.Customers.Where(w => w.IsActive);

            PrintCollection("Active Cusomters", activeCustomer);

            // SELECT * FROM Customers WHERE YearJoined < 1900 AND IsActive = True
            var longTimeCustomer = db.Customers.Where(w => w.YearJoined < 1900 && w.IsActive);

            PrintCollection("Long time customers", longTimeCustomer);


            // Creating
            // Create a new instance of a Model
            var newCustomer = new Customer
            {
                Name = "Hoss",
                IsActive = true,
                YearJoined = 1988,
                RewardPoints = 1000
            };
            // Add the new instance to the context
            db.Customers.Add(newCustomer);

            // save the changes to the database
            db.SaveChanges();
            
            var allCustomers = db.Customers.ToList();

            PrintCollection("All cusotmers", allCustomers);

            //Updating
            
            //// bring the item you want to update into Context 
            //var itemToUpdate = db.Customers.First(f => f.Name == "Irwin");

            //// update any fields
            //itemToUpdate.IsActive = false;
            //itemToUpdate.RewardPoints += 100;

            //// Commit change to the db
            //db.SaveChanges();

            var allCustomers2 = db.Customers.ToList();

            PrintCollection("All cusotmers -- updated", allCustomers2);

            // Deleting
            // bring items into context that you want to delete
            var toDelete = db.Customers.Where(f => f.Name == "Hoss");
            // Remove them
            db.Customers.RemoveRange(toDelete);
            // Commit changes to the DB
            db.SaveChanges();


            var allCustomers3 = db.Customers.ToList();

            PrintCollection("All cusotmers -- deleted", allCustomers3);


            // Adding a foreign Key
            
            // bring the customer into context
            var customer = db.Customers.First(f => f.Name == "Billy");

            // create a new Address, this will also bring into context
            customer.Address = new Address
            {
                AddressLine = "123 Fake",
                City = "NowwhereVille",
                State = " HA",
                Zip = "12345"
            };

            // commit changes, and add address to the database
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

            //// adding a new movie to a customer
            var movie = new Movies
            {
                Name = "Back to the Future"
            };

            var cus1 = db.Customers.First(f => f.Id == 2);
            cus1.Movies.Add(movie);
            db.SaveChanges();
        
            //// Add a customer to a new movie
            //var movie2 = new Movies { Name = "Jurassic Park" };
            //db.Movies.Add(movie2);

            //movie2.Customers.Add(cus1);
            //db.SaveChanges();


            // SELECT *
            // FROM Customers
            // LEFT JOIN Addresses ON Customers.AddressId = Address.Id
            // WHERE Customer.Name = 'Billy'

            var bill = db.Customers.First(f => f.Name == "Billy");

            var billy = db.Customers.Include(i => i.Address).First(w => w.Name == "Billy");

            var billyJoined = db.Customers // Left table
                                .Join(db.Addresses, // right table
                                fk => fk.AddressId, // Foreign Key
                                pk => pk.Id, // Primary Key
                                (c, address) => new { Person = c, Where = address }) // result
                                .First(w => w.Person.Name == "Billy"); // Where statement
   

            // list the discint cities  from aquairum table
            var dis = db.Addresses.Select(s => s.State).Distinct();



            // SELECT *
            // FROM Customers
            // LEFT JOIN Addresses ON Customers.AddressId = AddressId
            // WHERE Address.State = 'HA'

            var haCustomers = db.Customers
                                  .Join(db.Addresses,
                                  fk => fk.AddressId,
                                  pk => pk.Id,
                                  (c, a) => new { Person = c, Where = a })
                                  .First();
            haCustomers.Person.Name = "";
                                  
                                  





            Console.ReadLine();

        }
    }
}
