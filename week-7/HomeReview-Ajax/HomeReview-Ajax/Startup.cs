using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeReview_Ajax.Startup))]
namespace HomeReview_Ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
