using System.Reflection;
using Abp.Modules;

namespace Smart.AIMS
{
    [DependsOn(typeof(AIMSCoreModule))]
    public class AIMSApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
