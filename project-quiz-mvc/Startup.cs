using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(project_quiz_mvc.Startup))]
namespace project_quiz_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
