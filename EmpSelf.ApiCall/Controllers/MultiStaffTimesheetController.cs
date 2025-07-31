//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EmpSelf.ApiCall.Controllers
//{
//    public class MultiStaffTimesheetController
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpSelf.ApiCall.Framework;
using EmpSelf.Application.Models;
using EmpSelf.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpSelf.ApiCall.Controllers
{
    [Route("api/v1/multistafftimesheet")]
    [ApiController]
    public class MultiStaffTimesheetController : BaseController
    {
        private readonly IMultiStaffTimeSheetService _timesheetService;
        public MultiStaffTimesheetController(IMultiStaffTimeSheetService multiStafftimesheetService)
        {
            _timesheetService = multiStafftimesheetService;
        }


        [HttpPost("newtimesheet")]
        public IActionResult Post([FromBody] MultiStaffNewtimesheetModelDto requestDto)
        {

            return Response(_timesheetService.AddNewMultiStaffTimesheet(requestDto));

        }
        [HttpGet("get/{empid}")]
        public IActionResult Get(int empid)
        {

            return Response(_timesheetService.GetMultiStaffTimesheets(empid));

        }
        [HttpGet("getcurrent/{empid}")]
        public IActionResult GetCurrentDayTimesheet(int empid)
        {

            return Response(_timesheetService.GetCurrentMultiStaffTimesheets(empid));

        }
        [HttpGet("getdata/{timesheetid}")]
        ////public IActionResult GetData(int timesheetid)
        public IActionResult GetData(int timesheetid)
        {

           return Response(_timesheetService.GetMultiStaffTimesheetsData(timesheetid));
            
           // return _timesheetService.GetMultiStaffTimesheetsData(timesheetid);

        }
        [HttpGet("getdatabydate/{tdate}/{empid}/{flag}")]
        public IActionResult GetDataByDate(DateTime tdate, int empid, bool flag = false)
        {
            if (tdate == null) tdate = DateTime.Now;

            return Response(_timesheetService.GetMultiStaffTimesheetsByDate(tdate, empid, flag));

        }

        [HttpGet("filtertmesheets/{empid}/{month}/{year}")]
        public IActionResult FilterTimesheets(int empid, int month, int year)
        {
            return Response(_timesheetService.GetMultiStaffTimesheets(empid, month, year));

        }
        [HttpGet("getprojects")]
        public IActionResult getprojects()
        {

            return Response(_timesheetService.GetProjects());

        }

        [HttpGet("getstaffs")]
        public IActionResult getstaffs()
        {

            return Response(_timesheetService.GetStaff());

        }
    }
}