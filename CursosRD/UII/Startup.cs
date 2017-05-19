using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UII.Startup))]
namespace UII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
