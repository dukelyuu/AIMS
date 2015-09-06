using Abp.Web.Mvc.Views;

namespace Smart.AIMS.Web.Views
{
    public abstract class AIMSWebViewPageBase : AIMSWebViewPageBase<dynamic>
    {

    }

    public abstract class AIMSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AIMSWebViewPageBase()
        {
            LocalizationSourceName = AIMSConsts.LocalizationSourceName;
        }
    }
}