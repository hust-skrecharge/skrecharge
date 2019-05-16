using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SKR_User.Startup))]
namespace SKR_User
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
