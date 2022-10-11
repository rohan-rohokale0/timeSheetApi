using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverExpTimesheetAPI.Contract.Business;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.Contract.Repository;
using EverExpTimesheetAPI.DataContext.Models;
using EverExpTimesheetAPI.ViewModel.ViewModel;

namespace EverExpTimesheetAPI.Business
{
    public class CommonBusiness : ICommonBusiness
    {
        private IUnitOfWork _uow;
        private bool _disposed;
        private readonly IApproverRepository _approverRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IDepartmentRepository _departmentRepository; 
        private readonly IRepoManagerRepository _repoManagerRepository;
        private readonly ITypeRepository _typeRepository;
        public CommonBusiness(IRoleRepository roleRepository, IApproverRepository approverRepository, IProjectRepository projectRepository,IDepartmentRepository departmentRepository,IRepoManagerRepository repoManagerRepository,ITypeRepository typeRepository)
        {
            _roleRepository = roleRepository;
            _projectRepository = projectRepository;
            _approverRepository = approverRepository;
            _departmentRepository = departmentRepository;
            _repoManagerRepository = repoManagerRepository;
            _typeRepository = typeRepository;
            _disposed = false;
                    }
        public IUnitOfWork Uow
        {
            get { return _uow; }
            set
            {
                _uow = _approverRepository.Uow = value;
                _uow = _roleRepository.Uow = value;
                _uow = _projectRepository.Uow = value;
                _uow = _departmentRepository.Uow = value;
                _uow = _repoManagerRepository.Uow = value;
                _uow = _typeRepository.Uow = value;

            }
        }
        public async Task<IList<mApprover>> GetAllApprovers()
        {
            try
            {
                return await _approverRepository.SelectAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IList<mProject>> GetProjects()
        {
            try
            {
                return await _projectRepository.SelectAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IList<mRole>> GetRole()
        {
            try
            {
                return await _roleRepository.SelectAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<MasterViewModel> GetAllMasters()
        {
            MasterViewModel masterViewModel = new MasterViewModel();
            try
            {
                masterViewModel.lstApprover = await GetAllApprovers();
                masterViewModel.lstRole = await GetRole();
                masterViewModel.lstProject = await GetProjects();
                masterViewModel.mDepartment = await GetDepartments();
                masterViewModel.mType = await GetMTypes();
                masterViewModel.mRepoManager = await GetMRepoManager();

                return masterViewModel;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        public async Task<IList<mDepartment>> GetDepartments()
        {
            try
            {
                return await _departmentRepository.SelectAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<IList<mRepoManager>> GetMRepoManager()
        {
            try
            {
                return await _repoManagerRepository.SelectAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<IList<mType>> GetMTypes()
        {
            try
            {
                return await _typeRepository.SelectAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}