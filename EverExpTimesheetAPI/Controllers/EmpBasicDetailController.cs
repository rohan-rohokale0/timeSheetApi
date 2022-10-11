using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EverExpTimesheetAPI.Contract.Business;
using EverExpTimesheetAPI.Contract.Infrastructure;
using EverExpTimesheetAPI.ViewModel.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EverExpTimesheetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmpBasicDetailController : ControllerBase
    {
        private readonly IEmpBasicDetailBusiness _empBasicDetailBusiness;
        // GET: api/values
        public EmpBasicDetailController( IEmpBasicDetailBusiness empBasicDetailBusiness,IUnitOfWork uow)
        {
            _empBasicDetailBusiness = empBasicDetailBusiness;
            _empBasicDetailBusiness.Uow = uow;
        }
        //[HttpPost]
        //[ActionName("SaveEmpBasicDetails")]
        //public async Task<ResponseResult> SaveEmpBasicDetails([FromBody]EmpBasicDetailViewModel empBasicDetailViewModel)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest();
        //        }
        //        return Ok(await _empBasicDetailBusiness.SaveEmpBasicDetails(empBasicDetailViewModel));
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}

