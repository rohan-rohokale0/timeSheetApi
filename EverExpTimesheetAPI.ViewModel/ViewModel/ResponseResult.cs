using System;
namespace EverExpTimesheetAPI.ViewModel.ViewModel
{
    public class ResponseResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object ResultData { get; set; }
    }
}

