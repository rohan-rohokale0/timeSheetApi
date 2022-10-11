using System;
using System.ComponentModel.DataAnnotations;

namespace EverExpTimesheetAPI.DataContext.Models
{
    public partial class mTimeSheet
    {
        [Key]
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public int Approver_Id { get; set; }
        public bool Approve_Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

