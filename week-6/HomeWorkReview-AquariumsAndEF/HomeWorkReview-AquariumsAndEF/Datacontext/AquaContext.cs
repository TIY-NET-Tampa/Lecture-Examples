using HomeWorkReview_AquariumsAndEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkReview_AquariumsAndEF.Datacontext
{
    class AquaContext : DbContext
    {
        public AquaContext() : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Ocean> Oceans { get; set; }
        public DbSet<Aquarium> Aquariums  { get; set; }
        public DbSet<AquaticLIfe> AquaticLife { get; set; }
        public DbSet<AquariumAquaticLifeOcean> AquariumAquaticLifeOcean { get; set; }
        
    }
}
