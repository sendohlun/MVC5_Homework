using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_HOMEWORK.Startup))]
namespace MVC5_HOMEWORK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
