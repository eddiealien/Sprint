using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SprintWebCS.Startup))]
namespace SprintWebCS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
