using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChoresNet.Web.Startup))]
namespace ChoresNet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
