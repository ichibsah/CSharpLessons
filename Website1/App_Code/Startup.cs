using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website1.Startup))]
namespace Website1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
