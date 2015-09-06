using Abp.Application.Services;

namespace Smart.AIMS
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AIMSAppServiceBase : ApplicationService
    {
        protected AIMSAppServiceBase()
        {
            LocalizationSourceName = AIMSConsts.LocalizationSourceName;
        }
    }
}