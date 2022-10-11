using System;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.DataContext.Models;

namespace EverExpTimesheetAPI.Contract.Repository
{
    public interface IRoleRepository : IBaseRepository<mRole>, IDisposable
    {
        IUnitOfWork Uow { get; set; }

    }
}

