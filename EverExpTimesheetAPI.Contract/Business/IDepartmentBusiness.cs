using System;
using EverExpTimesheetAPI.Contract.Infrastructure;

namespace EverExpTimesheetAPI.Contract.Business
{
    public interface IDepartmentBusiness
    {
        public IUnitOfWork Uow { get; set; }
    }
}

