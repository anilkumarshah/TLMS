using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TLMS_UI.Startup))]
namespace TLMS_UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
