using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EverExpTimesheetAPI.Contract.Infrastructure
{
    public interface ISelectFirstOrDefaultService<TEntity> where TEntity : class
    {
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
