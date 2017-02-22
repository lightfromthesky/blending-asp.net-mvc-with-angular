using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleAngularWebMVCApp.Startup))]
namespace SampleAngularWebMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
