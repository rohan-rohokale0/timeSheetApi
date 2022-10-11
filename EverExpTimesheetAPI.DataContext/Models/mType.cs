using System;
using System.ComponentModel.DataAnnotations;

namespace EverExpTimesheetAPI.DataContext.Models
{
    public partial class mType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }


    }
}

