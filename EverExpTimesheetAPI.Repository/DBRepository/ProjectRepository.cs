using System;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.Contract.Repository;
using EverExpTimesheetAPI.DataContext.Models;

namespace EverExpTimesheetAPI.Repository.DBRepository
{
    public class ProjectRepository : BaseRepository<mProject>, IProjectRepository
    {
        private IUnitOfWork _uow;
        public new IUnitOfWork Uow
        {
            get { return _uow; }
            set
            {
                base.Uow = value;
                _uow = value;
            }
        }
        #region Public Methods

        #endregion
    }
}

