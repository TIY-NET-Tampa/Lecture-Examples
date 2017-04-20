namespace Homework_Review__Bootstrap.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Homework_Review__Bootstrap.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Homework_Review__Bootstrap.DataContext.SportsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Homework_Review__Bootstrap.DataContext.SportsContext context)
        {
            var games = new List<Game>
            {
                new Game { AwayScore = 10, HomeScore = 12, HomeTeam = "Swashbucklers", AwayTeam="Colonies"},
                new Game { AwayScore = 10, HomeScore = 12, HomeTeam = "Dragons", AwayTeam="Lancers"},
                new Game { AwayScore = 10, HomeScore = 12, HomeTeam = "Waves", AwayTeam="Anchors"}
            };

            games.ForEach(game => context.Games.AddOrUpdate(g => new { g.HomeTeam, g.AwayTeam, g.AwayScore, g.HomeScore }, game));
            context.SaveChanges();
        }
    }
}
