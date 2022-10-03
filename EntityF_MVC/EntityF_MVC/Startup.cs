using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityF_MVC.Startup))]
namespace EntityF_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
