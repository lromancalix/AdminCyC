using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminCyC.Startup))]
namespace AdminCyC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
