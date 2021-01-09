using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DapperMVCCRUD.Startup))]
namespace DapperMVCCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
