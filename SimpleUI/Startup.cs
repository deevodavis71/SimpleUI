using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleUI.Startup))]
namespace SimpleUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
