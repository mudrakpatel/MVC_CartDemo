using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_CartDemo.Startup))]
namespace MVC_CartDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
