using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoesStoreFE.Startup))]
namespace ShoesStoreFE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
