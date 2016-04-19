using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudCampExCD.Startup))]
namespace CloudCampExCD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
