using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleApi.Models
{
    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string FavoriteColor { get; set; }
    }
}