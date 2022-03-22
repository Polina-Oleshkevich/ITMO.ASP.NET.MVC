using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItogRating4.Startup))]
namespace ItogRating4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
