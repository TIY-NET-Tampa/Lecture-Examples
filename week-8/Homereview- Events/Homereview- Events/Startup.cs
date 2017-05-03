using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homereview__Events.Startup))]
namespace Homereview__Events
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
