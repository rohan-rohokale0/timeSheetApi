using System;
using EverExpTimesheetAPI.Contract.Infrastructure;

namespace EverExpTimesheetAPI.Contract.Business
{
    public interface ITypeBusiness
    {
        public IUnitOfWork Uow { get; set; }
    }
}

