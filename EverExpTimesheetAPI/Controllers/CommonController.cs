using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EverExpTimesheetAPI.Contract.Business;
using EverExpTimesheetAPI.Contract.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EverExpTimesheetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CommonController : ControllerBase
    {
        private readonly ICommonBusiness _commonBusiness;
        // GET: api/values
        public CommonController(ICommonBusiness commonBusiness, IUnitOfWork uow)
        {
            _commonBusiness = commonBusiness;
            _commonBusiness.Uow = uow;
        }
        [HttpGet]
        [ActionName ("GetAllData")]
        public async Task<ActionResult> GetAllData()
        {
            try
            {
                return Ok(await _commonBusiness.GetAllMasters());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpGet]
        [ActionName("GetDepartments")]
        public async Task<ActionResult> GetDepartments()
        {
            try
            {
                return Ok(await _commonBusiness.GetDepartments());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpGet]
        [ActionName("GetMRepoManager")]
        public async Task<ActionResult> GetMRepoManager()
        {
            try
            {
                return Ok(await _commonBusiness.GetMRepoManager());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpGet]
        [ActionName("GetMTypes")]
        public async Task<ActionResult> GetMTypes()
        {
            try
            {
                return Ok(await _commonBusiness.GetMTypes());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}

