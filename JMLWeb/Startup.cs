using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JMLWeb.Startup))]
namespace JMLWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
