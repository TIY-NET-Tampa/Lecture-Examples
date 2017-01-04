using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullAuthExample.Startup))]
namespace FullAuthExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
