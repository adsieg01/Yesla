using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yesla.Web.Startup))]
namespace Yesla.Web
{
    public class StripeSettings
    {
        public string SecretKey { get; set; }
        public string PublishableKey { get; set; }
    }

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }

   

    
}
