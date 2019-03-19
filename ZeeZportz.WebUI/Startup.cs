using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZeeZportz.WebUI.Startup))]
namespace ZeeZportz.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
