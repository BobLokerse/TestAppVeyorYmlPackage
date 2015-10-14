using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplWithAppveyorYml.Startup))]
namespace WebApplWithAppveyorYml
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
