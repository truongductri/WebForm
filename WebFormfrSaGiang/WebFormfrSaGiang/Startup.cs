using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormfrSaGiang.Startup))]
namespace WebFormfrSaGiang
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
