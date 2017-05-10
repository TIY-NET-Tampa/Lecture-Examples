using IntroToTesting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToTesting.DataContext
{
    public class CalcContext :DbContext
    {

        public DbSet<Answer> Answers{ get; set; }
    }
}
