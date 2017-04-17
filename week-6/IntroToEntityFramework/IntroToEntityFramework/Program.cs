using IntroToEntityFramework.DataContext;
using IntroToEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new PersonContext();


            // SELECT * FROM People
            var allPeople = db.People.ToList();



            // CREATE!

            var person = new Person
            {
                FullName = "Jerry",
                HairColor = "Bald",
                IsRightHanded = true,
                Height = 72,
                Age = 53
            };
            db.People.Add(person);
            db.SaveChanges();


            // READ

            var people = db.People.ToList();

            // SELECT * FROM People WHERE Age < 12

            var youngins = db.People.Where(peep => peep.Age < 12);

            // SELECT FullName FROM People 
            // WHERE HairColor = "Bald" && IsRightHanded = False

            var baldLefthandedPeopleNames = db.People
                .Where(w => !w.IsRightHanded && w.HairColor == "Bald")
                .Select(s => s.FullName);

            // UPDATING
            // SELECT TOP(1) * FROM PEOPLE WHERE FullName == "Jerry"
            // IN C#: using the reader, create a Person Object
            var jerry = db.People.First(f => f.FullName == "Jerry");

            // change the desired values
            jerry.HairColor = "Brown";
            

            // UPDATE PEOPLE SET (HairColor = "Brown") WHERE Id = Jerry.Id
            db.SaveChanges();


            var cities = db.Cities.ToList();


            var newYork = new Hometown
            {
                Name = "New York",
                Population = 12000000,
                State = "NY"
            };

            db.Cities.Add(newYork);
            db.SaveChanges();

            jerry.HomeTown = newYork;

            db.SaveChanges();

            var otherJerry = db.People.First(f => f.FullName == "Jerry");


            db.People.Remove(otherJerry);

        }
    }
}
