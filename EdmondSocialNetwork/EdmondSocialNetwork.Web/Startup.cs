using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EdmondSocialNetwork.Web.Startup))]
namespace EdmondSocialNetwork.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
