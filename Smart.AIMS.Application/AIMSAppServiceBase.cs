using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Runtime.Session;
using Smart.AIMS.MultiTenancy;
using Smart.AIMS.Users;

namespace Smart.AIMS
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AIMSAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected AIMSAppServiceBase()
        {
            LocalizationSourceName = AIMSConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }
    }
}