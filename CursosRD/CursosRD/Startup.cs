using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CursosRD.Startup))]
namespace CursosRD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
