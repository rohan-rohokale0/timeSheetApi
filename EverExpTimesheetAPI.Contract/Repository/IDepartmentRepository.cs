using System;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.DataContext.Models;

namespace EverExpTimesheetAPI.Contract.Repository
{
    public interface IDepartmentRepository : IBaseRepository <mDepartment>, IDisposable
    {
        IUnitOfWork Uow { get; set; }
    }
}

