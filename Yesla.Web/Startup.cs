using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yesla.Web.Startup))]
namespace Yesla.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
