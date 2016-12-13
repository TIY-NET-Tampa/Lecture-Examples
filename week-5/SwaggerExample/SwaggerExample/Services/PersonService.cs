using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SwaggerExample.Models;

namespace SwaggerExample.Services
{
    public static class PersonService
    {
        public static List<Person> People { get; set; } = new List<Person>
        {
            new Person {Name="Linda", HairColor="Brown" },
            new Person {Name = "Bernard", HairColor ="Bald" },
            new Person {Name = "Janet", HairColor="Red" },
            new Person {Name = "Arnold" ,HairColor = "Black" }
        };

        public static List<Person> GetAllPeople()
        {
            return People;
        }
        public static Person GetPerson(Guid id)
        {
            return People.FirstOrDefault(f => id == f.Id);
        }
        public static Person CreatePerson(string name, string hairColor)
        {

            var peep = new Person
            {
                Name = name,
                HairColor = hairColor
            };
            People.Add(peep);
            return peep;
        }
        public static Person UpdatePerson(Person personToUpdate)
        {
            var found = People.FirstOrDefault(f => f.Id == personToUpdate.Id);
            if (found != null)
            {
                found.Name = personToUpdate.Name;
                found.HairColor = personToUpdate.HairColor;
            }
            return found;
        }
        public static void DeletePerson(Guid id)
        {
            People = People.Where(w => w.Id != id).ToList();
        }
    }
}