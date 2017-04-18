namespace HomeWorkReview_AquariumsAndEF.Migrations
{
    using HomeWorkReview_AquariumsAndEF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeWorkReview_AquariumsAndEF.Datacontext.AquaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeWorkReview_AquariumsAndEF.Datacontext.AquaContext db)
        {
            var oceans = new List<Ocean>
            {
                new Ocean{Name = "Indian", AverageTemp = 72},
                new Ocean{Name = "Atlantic", AverageTemp = 68},
                new Ocean{Name = "Pacific", AverageTemp = 88},
                new Ocean{Name = "Arctic", AverageTemp = 13},
            };

            oceans.ForEach(oc => db.Oceans.AddOrUpdate(o => o.Name, oc));

            var fishes = new List<AquaticLIfe>
            {
                new AquaticLIfe{ Name ="Mr, Otter",Type="Otter", Color ="brown" },
                new AquaticLIfe {Name = "Jaws", Type = "Great white", Color = "white"},
                new AquaticLIfe { Name = "Mr Puff", Type ="Puffer", Color="yellow"}
            };
            fishes.ForEach(fish => db.AquaticLife.AddOrUpdate(f => f.Type, fish));

            var locations = new List<Aquarium>
            {
                new Aquarium {City = "Tampa Bay", Name = "Downtown Aquarium"},
                new Aquarium { City ="Fishburgh", Name = "Fish Tank"},
            };

            locations.ForEach(city => db.Aquariums.AddOrUpdate(c => c.Name, city));
            db.SaveChanges();

            var mrPuff = new AquariumAquaticLifeOcean
            {
                AquariumId = locations.First(f => f.Name == "Fish Tank").Id,
                OceanId = oceans.First(f => f.Name == "Indian").Id,
                AquaticLifeId = fishes.First(f => f.Name == "Mr Puff").Id
            };

            db.AquariumAquaticLifeOcean.AddOrUpdate(a => new { a.OceanId, a.AquariumId, a.AquaticLifeId }, mrPuff);



        }
    }
}
