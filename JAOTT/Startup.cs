using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JAOTT.Startup))]
namespace JAOTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
