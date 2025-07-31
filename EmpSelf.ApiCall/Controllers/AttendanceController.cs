using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EmpSelf.ApiCall.Framework;
using EmpSelf.Application.Models;
using EmpSelf.Application.Services;
using EmpSelf.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace EmpSelf.ApiCall.Controllers
{
    [Route("api/v1/atd")]
    [ApiController]
    public class AttendanceController : BaseController
    {
        private readonly IAttendanceService _attendanceService;
        private readonly IBreakTimeService _breakTimeService;
        private readonly ICurrentInfoServices _currentInfoServices;

        
        public AttendanceController(IAttendanceService attendanceService, ICurrentInfoServices currentInfoServices,IBreakTimeService breaktimeservice)
        {
            _attendanceService = attendanceService;
            _breakTimeService = breaktimeservice;
            _currentInfoServices = currentInfoServices;
        }
        [HttpGet("status/{empid}")]

        public IActionResult GetStatus(int empid)
        {
            return Response(_attendanceService.GetCurrentStatus(empid));
        }

        [HttpPost("checkin2")]
        public IActionResult Checkin2([FromForm] CheckINDto1 data)
        {
            return Response(_attendanceService.CHeckIN(data));


        }

       
        [HttpGet("currenttime")]
        public IActionResult CurrentTime()
        {
         
            return Response(_currentInfoServices.GetCurrentTime());
        }
        [HttpGet("breaktime/{empid}")]
        public IActionResult Breaktime(int empid)
        {
            return Response( _breakTimeService.GetBreakTime(empid));
        }


    }
}
