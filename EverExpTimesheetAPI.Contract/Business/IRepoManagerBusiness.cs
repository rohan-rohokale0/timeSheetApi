using System;
using EverExpTimesheetAPI.Contract.Infrastructure;

namespace EverExpTimesheetAPI.Contract.Business
{
    public interface IRepoManagerBusiness
    {
        public IUnitOfWork Uow { get; set; }
    }
}

