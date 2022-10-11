using System;
using EverExpTimesheetAPI.DataContext.Models;
using EverExpTimesheetAPI.Contract.Infrastructure;

namespace EverExpTimesheetAPI.Contract.Repository
{
    public interface IApproverRepository : IBaseRepository<mApprover>, IDisposable
    {
        IUnitOfWork Uow { get; set; }

    }
}
    
