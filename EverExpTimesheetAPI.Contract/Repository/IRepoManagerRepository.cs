using System;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.DataContext.Models;

namespace EverExpTimesheetAPI.Contract.Repository
{
    public interface IRepoManagerRepository : IBaseRepository<mRepoManager>, IDisposable
    {
        IUnitOfWork Uow { get; set; }
    }
}

