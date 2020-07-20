using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sitio_ALLOVER.Startup))]
namespace Sitio_ALLOVER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
