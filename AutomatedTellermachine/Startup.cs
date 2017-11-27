using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomatedTellermachine.Startup))]
namespace AutomatedTellermachine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
