using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEntityFramework.Models;


namespace IntroToEntityFramework.DataContext
{
    class PersonContext :DbContext
    {

        public PersonContext():base()
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Hometown> Cities { get; set; }
        public DbSet<Resturans> Resturans { get; set; }

    }
}
