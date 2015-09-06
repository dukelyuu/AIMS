using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Smart.AIMS
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AIMSApplicationModule))]
    public class AIMSWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AIMSApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
