using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mocking.Startup))]
namespace Mocking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
