using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EverExpTimesheetAPI.Contract.Infrastructure
{
    public interface ISelectService<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> SelectAsync(Expression<Func<TEntity,bool>> predicate=null);
    }
}
    