using System;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.DataContext.Models;

namespace EverExpTimesheetAPI.Contract.Repository
{
    public interface IProjectRepository : IBaseRepository<mProject>, IDisposable
    {
        IUnitOfWork Uow { get; set; }
    }
}

