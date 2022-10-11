using System;
using EverExpTimesheetAPI.DataContext.Models;
using Microsoft.EntityFrameworkCore;

namespace EverExpTimesheetAPI.DataContext.DataContext
{
    public partial class TimesheetContext :DbContext
    {
        public TimesheetContext()
        {

        }
        public TimesheetContext(DbContextOptions<TimesheetContext> options)
           : base(options)
        {
        }
        public virtual DbSet<mUser> mUser { get; set; }
        public virtual DbSet<mType> MType { get; set; }
        public virtual DbSet<mRole> MRole { get; set; }
        public virtual DbSet<mTimeSheet> MTimeSheets { get; set; }
        public virtual DbSet<timesheet> Timesheets { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<mApprover> MApprover { get; set; }
        public virtual DbSet<mDepartment> MDepartment { get; set; }
        public virtual DbSet<mProject> MProject { get; set; }
        public virtual DbSet<mRepoManager> MRepoManager { get; set; }
       
    }
}

