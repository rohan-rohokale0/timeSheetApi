using System;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.Contract.Repository;

namespace EverExpTimesheetAPI.Business
{
    public class ProjectBusiness
    {
        private IUnitOfWork _uow;
        private bool _disposed;
        private readonly IApproverRepository _approverRepository;
        private readonly IProjectRepository _projectRepository;
     
        public ProjectBusiness(IApproverRepository approverRepository, IProjectRepository projectRepository)
        {
           
            _projectRepository = projectRepository;
            _approverRepository = approverRepository;
            _disposed = false;

        }
        public IUnitOfWork Uow
        {
            get { return _uow; }
            set
            {
                _uow = _approverRepository.Uow = value;
                _uow = _projectRepository.Uow = value;

            }
        }

       
    }
}

