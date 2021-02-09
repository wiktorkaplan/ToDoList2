using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoList2.Startup))]
namespace ToDoList2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
