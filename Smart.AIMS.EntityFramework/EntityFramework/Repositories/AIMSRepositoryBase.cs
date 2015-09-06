using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Smart.AIMS.EntityFramework.Repositories
{
    public abstract class AIMSRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AIMSDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AIMSRepositoryBase(IDbContextProvider<AIMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AIMSRepositoryBase<TEntity> : AIMSRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AIMSRepositoryBase(IDbContextProvider<AIMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
