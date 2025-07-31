using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpSelf.ApiCall.Framework;
using EmpSelf.Application.Models;
using EmpSelf.Application.Services;
using EmpSelf.Core.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpSelf.ApiCall.Controllers
{
    [Route("api/v1/leave")]
    [ApiController]
    public class LeaveDataController : BaseController
    {
        private readonly ILeaveDataService _leavedataservice;
        public LeaveDataController(ILeaveDataService leavedataservice)
        {
            _leavedataservice = leavedataservice;

        }


        [HttpGet("getallLeaveBalanace/{empid}/{workgroupId}")]
        public IActionResult getallLeaveBalanace(int empid,int workgroupId)
        {

            return Response(_leavedataservice.GetAllLeaveBalance(empid, workgroupId));

        }


        [HttpPost("sendrequest")]
        public IActionResult Post([FromBody] NewLeaveDataDto requestDto)
        {

            return Response(_leavedataservice.NewLeaveRequest(requestDto));

        }
        [HttpGet("getleavedata/{EmpID}")]
        public IActionResult getleavedata( int EmpID)
        {

           // return Response(_leavedataservice.GetAll(EmpID));
            return Response(_leavedataservice.GetFilterData(EmpID, null, null));
        }

        [HttpGet("getallLeaveBal/{EmpID}")]
        public IActionResult getallLeaveBal(int EmpID)
        {

            return Response(_leavedataservice.GetAllLeaveBal(EmpID));

        }
        [HttpGet("getallstaff")]
        public IActionResult getallstaff()
        {

            return Response(_leavedataservice.getallstaff());

        }

        [HttpGet("getallLeaveBalType/{EmpID}/{Lcode}")]
        public IActionResult getallLeaveBalType(int EmpID, int Lcode)
        {

            return Response(_leavedataservice.GetAllLeaveBalType(EmpID,Lcode));

        }


        [HttpGet("getleaveFldata/{EmpID}/{fromdate}/{endate}")]
        public IActionResult getleaveFldata(int EmpID, DateTime fromdate, DateTime endate)
        {

            return Response(_leavedataservice.GetFilterData(EmpID, fromdate, endate));

        }

        [HttpGet("getleavedataID/{LID}")]
        public IActionResult getleavedataID(int LID)
        {

            return Response(_leavedataservice.GetDataWithID(LID));

        }

        [HttpGet("getleavependingdata/{EmpID}")]
        public IActionResult getleavependingdata(int EmpID)
        {

            return Response(_leavedataservice.GetPendingAll(EmpID));
        }

        [HttpGet("getallleavependingdata/{empName}/{fromdate}/{endate}/{companyId}")]
        public IActionResult getallleavependingdata(int empName, DateTime fromdate, DateTime endate, long companyId)
        {
             return Response(_leavedataservice.GetAllPending(empName,fromdate,endate,companyId));
        }

        [HttpGet("getallleaveapproveddata/{empName}/{fromdate}/{endate}/{companyId}")]
        public IActionResult getallleaveapproveddata(int empName, DateTime fromdate, DateTime endate,long companyId)
        {

            return Response(_leavedataservice.GetAllApproved(empName, fromdate, endate, companyId));
        }

        [HttpGet("getCompanies")]
        public IActionResult GetCompanies()
        {
            return Response(_leavedataservice.GetCompanies());
        }

        [HttpGet("GetCount/{EmpID}")]
        public IActionResult getcount(int EmpID)
        {

            return Response(_leavedataservice.GetCount(EmpID));
        }
        [HttpGet("GetstaffByAdminId/{EmpID}/{WorkgroupId}")]
        public IActionResult GetstaffByAdminId(int EmpID,int WorkgroupId)
        {

            return Response(_leavedataservice.GetstaffByAdminId(EmpID, WorkgroupId));
        }

        [HttpGet("delete/{leavedataid}")]
        public IActionResult delete(int leavedataid)
        {

            return Response(_leavedataservice.RemoveLeaveRequest(leavedataid));
        }


        [HttpGet("UpdateApprove/{leavedataid}/{stid}/{EmpID}/{StRem}")]
        public IActionResult Update(int leavedataid,int stid,int Empid,string StRem)
        {

            return Response(_leavedataservice.UpdateLeaveApproval(leavedataid,stid,Empid,StRem));
        }




    }
}
