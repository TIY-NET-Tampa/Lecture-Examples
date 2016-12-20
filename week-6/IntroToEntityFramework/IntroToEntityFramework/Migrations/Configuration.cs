namespace IntroToEntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IntroToEntityFramework.RentalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IntroToEntityFramework.RentalContext context)
        {


            context.Customers.AddOrUpdate(c => c.Id,
                new Models.Customer { Id = 1, Name = "Billy", YearJoined = 1998, IsActive = true, RewardPoints = 100 },
                new Models.Customer { Id = 2, Name = "Mandy", YearJoined = 1996, IsActive = true, RewardPoints = 0 },
                new Models.Customer { Id = 3, Name = "Grimm", YearJoined = 1000, IsActive = true, RewardPoints = 99 },
                new Models.Customer { Id = 4, Name = "Irwin", YearJoined = 1998, IsActive = false, RewardPoints = 99 }


                );



        }
    }
}
