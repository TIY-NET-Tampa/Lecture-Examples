namespace HomeworkReview_StackOverflow.Migrations
{
    using HomeworkReview_StackOverflow.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeworkReview_StackOverflow.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeworkReview_StackOverflow.Models.ApplicationDbContext context)
        {
            var defaultInstructor = "instruct@tiy.com";
            var password = "Password1!";

            if (!context.Users.Any(a => a.UserName == defaultInstructor))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = new ApplicationUser { UserName = defaultInstructor };

                userManager.Create(user, password);

                var questions = new List<Question>
                {
                    new Question{ Text =" This is my first question", Title = "Hello", UserId = user.Id},

                    new Question{ Text =" This is my other first question", Title = "Bonjour", UserId = user.Id},

                    new Question{ Text =" This is my second question", Title = "Hola", UserId = user.Id},

                    new Question{ Text =" This is my thrid question", Title = "Aloha", UserId = user.Id},

                    new Question{ Text =" This is my fifth question", Title = "Good Morning!", UserId = user.Id},
                };
                questions.ForEach(f => context.Questions.AddOrUpdate(a => a.Title, f));
                context.SaveChanges();
            }
            
        }
    }
}
