using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_playground.Startup))]
namespace aspnet_playground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
