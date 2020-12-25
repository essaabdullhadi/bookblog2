using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeBookNewUpdate.Startup))]
namespace WeBookNewUpdate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
