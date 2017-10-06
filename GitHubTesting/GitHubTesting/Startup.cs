using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTesting.Startup))]
namespace GitHubTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
