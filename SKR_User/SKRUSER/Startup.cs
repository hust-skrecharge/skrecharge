using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SKRUSER.Startup))]
namespace SKRUSER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
