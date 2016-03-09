using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(og.samples.aspnet.Demo.Startup))]
namespace og.samples.aspnet.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
