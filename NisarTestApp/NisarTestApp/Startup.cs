using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NisarTestApp.Startup))]
namespace NisarTestApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
