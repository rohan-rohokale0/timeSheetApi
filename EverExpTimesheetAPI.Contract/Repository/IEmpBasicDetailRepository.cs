using System;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.DataContext.Models;

namespace EverExpTimesheetAPI.Contract.Repository
{
    public interface IEmpBasicDetailRepository : IBaseRepository<UserDetail>, IDisposable
    {
        IUnitOfWork Uow { get; set; }
    }
}

