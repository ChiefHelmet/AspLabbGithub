using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb1Uppgift3OchFrammat.Startup))]
namespace Labb1Uppgift3OchFrammat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
