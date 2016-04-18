using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspLabbGithub.Startup))]
namespace AspLabbGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
