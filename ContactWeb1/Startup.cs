using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactWeb1.Startup))]
namespace ContactWeb1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
