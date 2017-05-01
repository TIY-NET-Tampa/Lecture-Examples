using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tweetter.Startup))]
namespace Tweetter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
