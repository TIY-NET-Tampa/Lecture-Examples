using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEntityFramework.Models;

namespace IntroToEntityFramework
{
    class RentalContext: DbContext
    {
        public RentalContext():base()
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Movies> Movies { get; set; }
        
    }
}
