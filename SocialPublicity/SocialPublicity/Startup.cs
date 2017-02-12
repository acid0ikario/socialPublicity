using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialPublicity.Startup))]
namespace SocialPublicity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
