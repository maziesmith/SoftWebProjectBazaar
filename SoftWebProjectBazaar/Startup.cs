using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftWebProjectBazaar.Startup))]
namespace SoftWebProjectBazaar
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
