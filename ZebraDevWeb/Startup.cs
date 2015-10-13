using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZebraDevWeb.Startup))]
namespace ZebraDevWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
