using System;
using System.Threading.Tasks;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.DataContext.Models;
using EverExpTimesheetAPI.ViewModel.ViewModel;

namespace EverExpTimesheetAPI.Contract.Business
{
    public interface IEmpBasicDetailBusiness
    {
        public IUnitOfWork Uow { get; set; }
        public Task<ResponseResult> SaveEmpBasicDetails(EmpBasicDetailViewModel empBasicDetailViewModel);
        //  public Task<List<mApprover>> GetApprovers();
        // public Task<List<mProject>> GetProjects();
        // public Task<List<mDepartment>> GetDepartment();
        // public Task<List<mRepoManager>> GetRepoManagers();
        // public Task<List<mRole>> GetRoles();
    }
}

