using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeworkReview_Reddit_WithAuth.Startup))]
namespace HomeworkReview_Reddit_WithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
