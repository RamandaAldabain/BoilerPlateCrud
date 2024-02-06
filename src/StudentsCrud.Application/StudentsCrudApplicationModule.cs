using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StudentsCrud.Authorization;

namespace StudentsCrud
{
    [DependsOn(
        typeof(StudentsCrudCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StudentsCrudApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<StudentsCrudAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(StudentsCrudApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
