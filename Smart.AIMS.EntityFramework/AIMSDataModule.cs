using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Smart.AIMS.EntityFramework;

namespace Smart.AIMS
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AIMSCoreModule))]
    public class AIMSDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AIMSDbContext>(null);
        }
    }
}
