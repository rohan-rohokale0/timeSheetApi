using System;
using System.ComponentModel.DataAnnotations;

namespace EverExpTimesheetAPI.DataContext.Models
{
    public partial class timesheet
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date{get;set;}
         public int Employee_Id { get; set; }
         public int Project_Id { get; set; }
    public decimal Hours { get; set; }
    public int Project_Mngr_Id { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }


}
}

