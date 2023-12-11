using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetC__CRUD.Startup))]
namespace NetC__CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
