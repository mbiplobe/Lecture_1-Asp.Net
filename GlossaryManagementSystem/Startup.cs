using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlossaryManagementSystem.Startup))]
namespace GlossaryManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
