using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFOnTheWeb.Models
{
    public class DealershipContext:DbContext
    {

        public DealershipContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}