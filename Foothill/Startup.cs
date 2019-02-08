using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Foothill.Startup))]
namespace Foothill
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
