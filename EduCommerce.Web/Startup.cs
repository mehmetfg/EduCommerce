using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EduCommerce.Web.Startup))]
namespace EduCommerce.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
