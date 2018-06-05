using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(our_store.Startup))]
namespace our_store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
