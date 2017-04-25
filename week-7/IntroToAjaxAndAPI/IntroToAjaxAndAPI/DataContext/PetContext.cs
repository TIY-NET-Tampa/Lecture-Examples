using IntroToAjaxAndAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntroToAjaxAndAPI.DataContext
{
    public class PetContext :DbContext
    {
        public DbSet<Pet> Petsn{ get; set; }
    }
}