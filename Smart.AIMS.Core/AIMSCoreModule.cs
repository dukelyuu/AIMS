using System.Reflection;
using Abp.Modules;

namespace Smart.AIMS
{
    public class AIMSCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
