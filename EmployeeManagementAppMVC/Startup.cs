using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeManagementAppMVC.Startup))]
namespace EmployeeManagementAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
