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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EmpSelf.ApiCall.Controllers
{
    [Route("api/v1/service")]
    [ApiController]
    public class ServiceController : BaseController
    {
        private readonly IServiceRequestService _ServiceRequestService;
        private readonly IServiceRequestType _ServiceRequestType;

        public ServiceController(IServiceRequestService ServiceRequestService, IServiceRequestType ServiceRequestType)
        {
            _ServiceRequestService = ServiceRequestService;
            _ServiceRequestType = ServiceRequestType;
        }
        [HttpPost("sendrequest")]
        public IActionResult Post([FromBody] NewServiceRequest requestDto)
        {

            return Response(_ServiceRequestService.AddNewServiceReq(requestDto));

        }
        [HttpGet("getservices/{EmpID}")]
        public IActionResult GetServiceData(int EmpID)
        {
            //return Response(_ServiceRequestService.GetServiceRequest(EmpID));
            return Response(_ServiceRequestService.GetFilterData(EmpID, null, null));
        }


        [HttpGet("getStaffById/{EmpID}")]
        public IActionResult getStaffById(int EmpID)
        {
            //return Response(_ServiceRequestService.GetServiceRequest(EmpID));
            return Response(_ServiceRequestService.GetStaffById(EmpID));
        }

        [HttpGet("getserviceFldata/{EmpID}/{fromdate}/{endate}")]
        public IActionResult getserviceFldata(int EmpID, DateTime fromdate, DateTime endate)
        {

            return Response(_ServiceRequestService.GetFilterData(EmpID, fromdate, endate));

        }

        [HttpGet("getservicesbyId/{SID}")]
        public IActionResult GetServiceDataById(int SID)
        {
            return Response(_ServiceRequestService.GetServiceRequestById(SID));

        }


        [HttpGet("getallservice/{empName}/{fromdate}/{endate}/{companyId}/{typeId}")]
        public IActionResult GetAllServiceData(int empName, DateTime fromdate, DateTime endate,long companyId,int typeId)
        {
            return Response(_ServiceRequestService.GetAllServiceRequest(empName, fromdate, endate, companyId, typeId));

        }
        [HttpGet("getall_Approved_Service/{empName}/{fromdate}/{endate}/{companyId}/{typeId}/{serviceReqStatus}")]
        public IActionResult GetAllApprovedServiceData(int empName, DateTime fromdate, DateTime endate, long companyId, int typeId, int serviceReqStatus)
        {
            return Response(_ServiceRequestService.GetAllApprovedServiceData(empName, fromdate, endate, companyId, typeId,serviceReqStatus));

        }

        [HttpGet("delete/{serviceID}")]
        public IActionResult delete(int serviceID)
        {

            return Response(_ServiceRequestService.RemoveserviceRequest(serviceID));
        }
        [HttpGet("getserviceType")]
        public IActionResult getserviceType()
        {
            return Response(_ServiceRequestType.GetServiceType());

        }

        [HttpGet("UpdateApproval/{serviceid}/{stid}/{EmpID}/{strem}")]
        public IActionResult Update(int serviceid, int stid, int EmpID,string StRem)
        {

            return Response(_ServiceRequestService.UpdateServiceApproval(serviceid, stid,EmpID,StRem));
        }
    }
}
