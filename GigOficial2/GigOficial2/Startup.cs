using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigOficial2.Startup))]
namespace GigOficial2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
