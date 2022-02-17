using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviePlanet.Startup))]
namespace MoviePlanet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
