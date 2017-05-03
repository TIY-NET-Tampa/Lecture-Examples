namespace Homereview__Events.Migrations
{
    using Homereview__Events.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Homereview__Events.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Homereview__Events.Models.ApplicationDbContext context)
        {
            var ownerRole = "owner";
            var store = new RoleStore<IdentityRole>(context);
            var manager = new RoleManager<IdentityRole>(store);

            if (!context.Roles.Any(a => a.Name == ownerRole))
            {
                var role = new IdentityRole { Name = ownerRole };
                manager.Create(role);
            }

            var ownerEmail = "owner@event.com";
            var defaultPassword = "Password1!";
            if (!context.Users.Any(u => u.UserName == ownerEmail))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = new ApplicationUser { UserName = ownerEmail };

                userManager.Create(user, defaultPassword);
                userManager.AddToRole(user.Id, ownerRole);
            }


            var concert = new Genre { Name = "Conert" };

            context.Genres.AddOrUpdate(g => g.Name, concert);

            var venue = new Venue { Name = "Janus" };
            context.Venues.AddOrUpdate(v => v.Name, venue);
            context.SaveChanges();

            var es = new List<EventModel>
            {
                new EventModel{Title ="Band A", VenueId = venue.Id, GenreId = concert.Id, StartDate = DateTime.Now},


                new EventModel{Title ="Band B", VenueId = venue.Id, GenreId = concert.Id,StartDate = DateTime.Now},


                new EventModel{Title ="Band C", VenueId = venue.Id, GenreId = concert.Id,StartDate = DateTime.Now},
                new EventModel{Title ="Band D", VenueId = venue.Id, GenreId = concert.Id, StartDate = DateTime.Now},
            };

            es.ForEach(ent => context.Events.AddOrUpdate(e => e.Title, ent));
            context.SaveChanges();

        }
    }
}
