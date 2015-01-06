using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(og.samples.aspnet.MetaDataClass.Startup))]
namespace og.samples.aspnet.MetaDataClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
