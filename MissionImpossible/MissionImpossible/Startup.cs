using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MissionImpossible.Startup))]
namespace MissionImpossible
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
