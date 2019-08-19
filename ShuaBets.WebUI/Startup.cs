using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShuaBets.WebUI.Startup))]
namespace ShuaBets.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
