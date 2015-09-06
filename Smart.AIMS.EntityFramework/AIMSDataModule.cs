using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Smart.AIMS.EntityFramework;

namespace Smart.AIMS
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AIMSCoreModule))]
    public class AIMSDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
