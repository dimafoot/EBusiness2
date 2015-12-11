using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEBAWS.Startup))]
namespace WEBAWS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
