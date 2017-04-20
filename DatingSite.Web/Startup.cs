using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatingSite.Web.Startup))]
namespace DatingSite.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
