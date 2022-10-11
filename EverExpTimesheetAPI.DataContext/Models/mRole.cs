using System;
using System.ComponentModel.DataAnnotations;

namespace EverExpTimesheetAPI.DataContext.Models
{
    public partial class mRole
    {
        [Key]
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }


    }
}

