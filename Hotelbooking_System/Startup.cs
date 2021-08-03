using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hotelbooking_System.Startup))]
namespace Hotelbooking_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
