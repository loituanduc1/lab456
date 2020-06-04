using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bigschool3.Startup))]
namespace bigschool3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
