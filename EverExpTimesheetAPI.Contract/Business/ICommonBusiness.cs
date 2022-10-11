
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.DataContext.Models;
using EverExpTimesheetAPI.ViewModel.ViewModel;

namespace EverExpTimesheetAPI.Contract.Business
{
    public interface ICommonBusiness
    {
        public IUnitOfWork Uow { get; set; }
       public Task<IList<mApprover>> GetAllApprovers();
        public Task<IList<mProject>> GetProjects();
       public Task<IList<mRole>> GetRole();
        public Task<MasterViewModel> GetAllMasters();
        public Task<IList<mDepartment>>GetDepartments();
        public Task<IList<mRepoManager>> GetMRepoManager();
        public Task<IList<mType>> GetMTypes();
    }
}

