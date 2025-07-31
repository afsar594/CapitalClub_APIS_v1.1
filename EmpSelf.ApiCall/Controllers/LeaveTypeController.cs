using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpSelf.ApiCall.Framework;
using EmpSelf.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpSelf.ApiCall.Controllers
{
   // [Authorize]
    [Route("api/v1/leavetype")]
    [ApiController]
    public class LeaveTypeController : BaseController
    {
        private readonly ILeaveDataType _leaveTypeService;
        public LeaveTypeController(ILeaveDataType leaveTypeService)
        {
            _leaveTypeService = leaveTypeService;
        }
        [HttpGet("Get")]
        public IActionResult Get()
        {

            return Response(_leaveTypeService.GetLeaveType());

        }
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {

            return Response(_leaveTypeService.GetAllUsers());

        }

        

        [HttpGet("GetLeaveTypebyId/{UserID}")]
        public IActionResult GetLeaveTypebyID(int UserID)
        {
            var result = _leaveTypeService.GetLeaveTypebyID(UserID);
            return Ok(result);
        }


    }
}
