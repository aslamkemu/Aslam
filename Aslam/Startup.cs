using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aslam.Startup))]
namespace Aslam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
