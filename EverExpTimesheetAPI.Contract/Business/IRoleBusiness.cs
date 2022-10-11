using System;
using EverExpTimesheetAPI.Contract.Infrastructure;

namespace EverExpTimesheetAPI.Contract.Business
{
    public interface IRoleBusiness
    {
        public IUnitOfWork Uow { get; set; }
    }
}

