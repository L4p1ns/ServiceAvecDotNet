using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsService.Startup))]
namespace ConsService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
