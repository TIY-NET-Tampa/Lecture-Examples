using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Homework_Review__Bootstrap.Models;

namespace Homework_Review__Bootstrap.DataContext
{
    public class SportsContext :DbContext
    {

        public SportsContext() :base("name=DefaultConnection")
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}