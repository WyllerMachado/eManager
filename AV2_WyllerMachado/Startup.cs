using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AV2_WyllerMachado.Startup))]
namespace AV2_WyllerMachado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
