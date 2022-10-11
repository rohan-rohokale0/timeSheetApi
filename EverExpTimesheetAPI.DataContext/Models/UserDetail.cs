using System;
using System.ComponentModel.DataAnnotations;

namespace EverExpTimesheetAPI.DataContext.Models
{
    public partial class UserDetail
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public int Approver_Id { get; set; }
        public int Project_Id { get; set; }
        public int RoleId { get; set; }
        public int Department_Id { get; set; }
        public int Reporting_Manager_Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }


    }
}

