using System;
using System.Collections.Generic;
using EverExpTimesheetAPI.DataContext.Models;

namespace EverExpTimesheetAPI.ViewModel.ViewModel
{
    public class MasterViewModel
    {
        public IList<mApprover> lstApprover { get; set; }
        public IList<mProject> lstProject { get; set; }
        public IList<mRole> lstRole { get; set; }
        public IList<mDepartment> mDepartment { get; set;}
        public IList<mRepoManager> mRepoManager { get; set; }
        public IList<mType> mType { get; set; }
    }
}

