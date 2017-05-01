using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeworkReview_StackOverflow.Startup))]
namespace HomeworkReview_StackOverflow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
