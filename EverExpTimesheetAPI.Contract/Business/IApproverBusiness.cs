using System;
using EverExpTimesheetAPI.Contract.Infrastructure;

namespace EverExpTimesheetAPI.Contract.Business
{
    public interface IApproverBusiness
    {
        public IUnitOfWork Uow { get; set; }
    }
}

