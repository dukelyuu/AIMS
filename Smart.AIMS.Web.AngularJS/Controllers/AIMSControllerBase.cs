using Abp.Web.Mvc.Controllers;

namespace Smart.AIMS.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AIMSControllerBase : AbpController
    {
        protected AIMSControllerBase()
        {
            LocalizationSourceName = AIMSConsts.LocalizationSourceName;
        }
    }
}