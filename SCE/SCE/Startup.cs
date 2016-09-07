using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCE.Startup))]
namespace SCE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
