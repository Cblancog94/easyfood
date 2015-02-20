using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyFood.Startup))]
namespace EasyFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
