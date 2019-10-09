using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrototypeDesignPattern.Startup))]
namespace PrototypeDesignPattern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
