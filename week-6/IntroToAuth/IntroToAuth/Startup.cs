using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroToAuth.Startup))]
namespace IntroToAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
