using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizCreator.Startup))]
namespace QuizCreator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
