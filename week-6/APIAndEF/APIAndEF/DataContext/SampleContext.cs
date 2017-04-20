using APIAndEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIAndEF.DataContext
{
    public class SampleContext :DbContext
    {
        public SampleContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Sandwhich> Sandwhich { get; set; }
    }
}