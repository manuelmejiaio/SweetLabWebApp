using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SweetLabWebApp.Startup))]
namespace SweetLabWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
