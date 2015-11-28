using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Juve.Web.Startup))]
namespace Juve.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
