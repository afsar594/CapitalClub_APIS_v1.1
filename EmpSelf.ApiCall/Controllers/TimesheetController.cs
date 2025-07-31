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
    [Route("api/v1/timesheet")]
    [ApiController]
    public class TimesheetController : BaseController
    {
        private readonly ITimesheetService _timesheetService;
        public TimesheetController(ITimesheetService timesheetService)
        {
            _timesheetService = timesheetService;
        }


        [HttpPost("newtimesheet")]
        public IActionResult Post([FromBody] NewtimesheetModelDto requestDto)
        {

            return Response(_timesheetService.AddNewTimesheet(requestDto));

        }

        ////[HttpPost("Updatetimesheet")]
        ////public IActionResult Postupdate([FromBody] NewtimesheetModelDto requestDto)
        ////{

        ////    return Response(_timesheetService.UpdateTimesheet(requestDto));

        ////}



        [HttpGet("get/{empid}")]
        public IActionResult Get(int empid)
        {

            return Response(_timesheetService.GetTimesheets(empid));

        }
        [HttpGet("getcurrent/{empid}")]
        public IActionResult GetCurrentDayTimesheet(int empid)
        {

            return Response(_timesheetService.GetCurrentTimesheets(empid));

        }
        [HttpGet("getdata/{timesheetid}")]
        public IActionResult GetData(int timesheetid)
        {

            return Response(_timesheetService.GetTimesheetsData(timesheetid));

        }
        [HttpGet("getdatabydate/{tdate}/{empid}/{flag}")]
        public IActionResult GetDataByDate(DateTime tdate, int empid, bool flag = false)
        {
                if (tdate == null) tdate = DateTime.Now;

            return Response(_timesheetService.GetTimesheetsByDate(tdate, empid, flag));

        }

        [HttpGet("filtertmesheets/{empid}/{month}/{year}")]
        public IActionResult FilterTimesheets(int empid,int month, int year)
        {
            return Response(_timesheetService.GetTimesheets(empid,month, year));

        }
        [HttpGet("getprojects")]
        public IActionResult getprojects()
        {

            return Response(_timesheetService.GetProjects());

        }
    }
}
