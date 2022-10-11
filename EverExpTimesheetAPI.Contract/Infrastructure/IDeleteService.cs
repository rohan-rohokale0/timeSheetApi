using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverExpTimesheetAPI.Contract.Infrastructure
{
    public interface IDeleteService<TEntity> where TEntity : class
    {
        Task DeleteAsync(TEntity entity);
    }
}
