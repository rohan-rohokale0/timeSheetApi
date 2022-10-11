using System;
using System.ComponentModel.DataAnnotations;

namespace EverExpTimesheetAPI.DataContext.Models
{
    public partial class mApprover
    {
        [Key]
        public int ApproverId { get; set; }
        public string ApproverName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }


    }
}

