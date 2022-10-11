using System;
using EverExpTimesheetAPI.Business;
using EverExpTimesheetAPI.Contract.Business;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.Contract.Repository;
using EverExpTimesheetAPI.DataContext.DataContext;
using EverExpTimesheetAPI.Repository;
using EverExpTimesheetAPI.Repository.DBRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace EverExpTimesheetAPI.DependencyInjection
{
    public class DependenceInjectionContainer
    {
        public static class DBContainer
        {
            public static void Injector(IServiceCollection services)
            {
                #region Add Context And UnitOfWork
                services.AddScoped<IUnitOfWork, UnitOfWork>();
                services.AddScoped<DbContext, TimesheetContext>();
                #endregion

              
                //Repository
                services.AddScoped<IProjectRepository, ProjectRepository>();
                services.AddScoped<IRoleRepository, RoleRepository>();
                services.AddScoped<IEmpBasicDetailRepository, EmpBasicDetailRepository>();
                services.AddScoped<IDepartmentRepository, DepartmentRepository>();
                services.AddScoped<ITypeRepository, TypeRepository>();
                services.AddScoped<IApproverRepository, ApproverRepository>();
                services.AddScoped<IRepoManagerRepository, RepoManagerRepository>();
                //Business
                services.AddScoped<ICommonBusiness, CommonBusiness>();
                services.AddScoped<IEmpBasicDetailBusiness, EmpBasicDetailBusiness>();
                
                
            }
        }
    }
}
