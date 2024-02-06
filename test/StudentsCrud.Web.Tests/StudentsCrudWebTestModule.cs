using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StudentsCrud.EntityFrameworkCore;
using StudentsCrud.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace StudentsCrud.Web.Tests
{
    [DependsOn(
        typeof(StudentsCrudWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class StudentsCrudWebTestModule : AbpModule
    {
        public StudentsCrudWebTestModule(StudentsCrudEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StudentsCrudWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(StudentsCrudWebMvcModule).Assembly);
        }
    }
}