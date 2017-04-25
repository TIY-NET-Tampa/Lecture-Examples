using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JsInBrowser.Startup))]
namespace JsInBrowser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
