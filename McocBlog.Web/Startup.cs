using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(McocBlog.Web.Startup))]
namespace McocBlog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
