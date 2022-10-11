
using System;
using System.Threading.Tasks;
using EverExpTimesheetAPI.Contract.Business;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.Contract.Repository;
using EverExpTimesheetAPI.DataContext.Models;
using EverExpTimesheetAPI.ViewModel.ViewModel;

namespace EverExpTimesheetAPI.Business
{
    public class EmpBasicDetailBusiness : IEmpBasicDetailBusiness
    {
        private readonly IEmpBasicDetailRepository _basicDetailRepository;
        private IUnitOfWork _uow;
        private bool _disposed;
        public EmpBasicDetailBusiness(IEmpBasicDetailRepository basicDetailRepository)
        {
            _basicDetailRepository = basicDetailRepository;
        }
        public IUnitOfWork Uow
        {
            get { return _uow; }
            set
            {
                _uow = _basicDetailRepository.Uow = value;
              

            }
        }
        public async Task<ResponseResult> SaveEmpBasicDetails(EmpBasicDetailViewModel empBasicDetailViewModel)
        {
            ResponseResult responseResult = new ResponseResult();
            responseResult.Success = false;
            DateTime dt = DateTime.Now;
            UserDetail userDetail = new UserDetail()
            {
                User_Id = empBasicDetailViewModel.EmpId,
                Approver_Id = empBasicDetailViewModel.ApproverId,
                RoleId = empBasicDetailViewModel.RoleId,
                Project_Id = empBasicDetailViewModel.ProjectId,
                Department_Id = empBasicDetailViewModel.DepartmentId,
               
                CreatedDate = dt,
                ModifiedDate=dt
            };

            await _basicDetailRepository.AddAsync(userDetail);
            await _uow.SaveChangesAsync();
            responseResult.Success = true;
            responseResult.Message = "Employee Basic Details Added Successfully.";
            return responseResult;
        }
        #region Dispose

        /// <summary>
        /// Method to dispose by parameter.
        /// </summary>
        /// <param name="disposing"></param>
        /// 
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _basicDetailRepository.Dispose();
               
            }

            _disposed = true;
        }

        /// <summary>
        /// Method to dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
        // public async Task<List<mApprover>> GetApprovers()
        //{
        //   List<mApprover> lstApprovers = new List<mApprover>();
        //  try
        //  {
        // IList<mApprover> causeMasters = await _basicDetailRepository.SelectAsync();

        // }
        // catch (Exception ex)
        // {

        //}
        //  return lstApprovers;
        // }
    }
}

