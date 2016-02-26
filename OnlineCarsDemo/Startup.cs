using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineCarsDemo.Startup))]
namespace OnlineCarsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
