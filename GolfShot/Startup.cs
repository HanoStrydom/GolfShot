using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GolfShot.Startup))]
namespace GolfShot
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
