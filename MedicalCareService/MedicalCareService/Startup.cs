using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicalCareService.Startup))]
namespace MedicalCareService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
