using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestUnit6.Startup))]
namespace TestUnit6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
