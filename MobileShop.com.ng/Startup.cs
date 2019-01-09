using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobileShop.com.ng.Startup))]
namespace MobileShop.com.ng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
