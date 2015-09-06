using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Smart.AIMS
{
    [DependsOn(typeof(AIMSCoreModule), typeof(AbpAutoMapperModule))]
    public class AIMSApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
