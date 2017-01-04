using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WelcomeToAuth.Startup))]
namespace WelcomeToAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
