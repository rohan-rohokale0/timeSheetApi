using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverExpTimesheetAPI.Contract.Infrastructure
{
    public interface IUpdateService<TEntity> where TEntity : class
    {
        Task UpdateAsync(TEntity entity);  
        
    }
}
