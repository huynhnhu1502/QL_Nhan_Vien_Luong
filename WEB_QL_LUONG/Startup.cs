using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEB_QL_LUONG.Startup))]
namespace WEB_QL_LUONG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
