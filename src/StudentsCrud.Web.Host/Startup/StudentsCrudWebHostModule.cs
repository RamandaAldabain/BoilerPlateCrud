using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StudentsCrud.Configuration;

namespace StudentsCrud.Web.Host.Startup
{
    [DependsOn(
       typeof(StudentsCrudWebCoreModule))]
    public class StudentsCrudWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public StudentsCrudWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StudentsCrudWebHostModule).GetAssembly());
        }
    }
}
