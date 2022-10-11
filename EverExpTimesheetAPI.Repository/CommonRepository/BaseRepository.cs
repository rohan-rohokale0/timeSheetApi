using EverExpTimesheetAPI.Contract.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EverExpTimesheetAPI.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>, IDisposable where TEntity : class
    {
        #region Public Properties
        public IUnitOfWork Uow { get; set; }
        #endregion

        #region Constructor
        public BaseRepository()
        {
        }   
        #endregion

        #region public Methods

        #region Get Methods
        public async Task<IList<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
                return await Uow.DataContext.Set<TEntity>().Where(predicate).ToListAsync();
            else
                return await Uow.DataContext.Set<TEntity>().ToListAsync();
        }
        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
                return await Uow.DataContext.Set<TEntity>().Where(predicate).CountAsync();
            else
                return await Uow.DataContext.Set<TEntity>().CountAsync();
        }

        public async Task<TEntity> SelectSingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Uow.DataContext.Set<TEntity>().Where(predicate).FirstOrDefaultAsync();
        }
        #endregion

        #region "Add Method"
        /// <summary>
        /// Add new record in entity provided by repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task AddAsync(TEntity entity)
        {
           await Uow.DataContext.Set<TEntity>().AddAsync(entity);
        }
       public virtual async Task AddRangeAsync(IEnumerable<TEntity> entity)
        {
           await Uow.DataContext.Set<TEntity>().AddRangeAsync(entity);
       }
       
        #endregion

        #region "Update Method"
        /// <summary>
        /// Modify single record from entity provided by repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task UpdateAsync(TEntity entity)
        {

            await Task.Run(() => Uow.DataContext.Set<TEntity>().Update(entity));

        }
        #endregion

        #region "Delete Method"
        /// <summary>
        /// Delete single record from entity provided by repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task DeleteAsync(TEntity entity)
        {

            await Task.Run(() => Uow.DataContext.Set<TEntity>().Remove(entity));

        }
        #endregion

        #endregion
        #region Dispose
        /// <summary>
        /// Method to dispose.
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        


        #endregion
    }
}
