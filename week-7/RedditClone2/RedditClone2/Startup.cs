using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedditClone2.Startup))]
namespace RedditClone2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
