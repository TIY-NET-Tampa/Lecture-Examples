namespace APIAndEF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<APIAndEF.DataContext.SampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APIAndEF.DataContext.SampleContext context)
        {
            var food = new System.Collections.Generic.List<Models.Sandwhich>
            {
                new Models.Sandwhich{ Bread ="Cuban Bread", Cheese="Swiss", HasLettuce=false, MainItem="pork"}
            };

            context.Sandwhich.AddOrUpdate(a => a.MainItem, food.First());
            context.SaveChanges();
        }
    }
}
