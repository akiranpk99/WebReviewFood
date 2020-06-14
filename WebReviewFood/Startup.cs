using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebReviewFood.Startup))]
namespace WebReviewFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
