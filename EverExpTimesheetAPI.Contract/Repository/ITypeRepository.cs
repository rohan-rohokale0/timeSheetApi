using System;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.DataContext.Models;

namespace EverExpTimesheetAPI.Contract.Repository
{
    public interface ITypeRepository : IBaseRepository<mType>, IDisposable
    {
        IUnitOfWork Uow { get; set; }
    }
}

