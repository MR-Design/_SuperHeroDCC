using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_Superhero.Startup))]
namespace _Superhero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
