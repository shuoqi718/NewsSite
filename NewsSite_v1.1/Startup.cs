using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsSite_v1._1.Startup))]
namespace NewsSite_v1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
