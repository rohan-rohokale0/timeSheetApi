using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EverExpTimesheetAPI.Contract.Infrastructure
{
    public interface IBaseRepository<TEntity> : IAddService<TEntity>, IUpdateService<TEntity>, IDeleteService<TEntity>, ISelectService<TEntity> where TEntity : class
    {
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null);
        Task<TEntity> SelectSingleAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
