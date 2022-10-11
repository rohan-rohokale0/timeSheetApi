using System;
using System.ComponentModel.DataAnnotations;

namespace EverExpTimesheetAPI.DataContext.Models
{
    public partial class mDepartment
    {
        [Key]
        public int Department_Id { get; set; }
        public string Department_Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}

