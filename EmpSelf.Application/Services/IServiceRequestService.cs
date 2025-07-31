using EmpSelf.Application.Models;
using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
   public interface IServiceRequestService
    {
        CommonResponse GetServiceRequest(int EMPID);
        CommonResponse GetFilterData(int EmpID, DateTime? DateFrom, DateTime? DateTo);
        CommonResponse GetServiceRequestById(int SID);

        CommonResponse GetStaffById(int EmpID);
        CommonResponse GetAllServiceRequest(int EmpName, DateTime DateFrom, DateTime DateTo,long companyId ,int typeId);
        CommonResponse AddNewServiceReq(NewServiceRequest NewService);
        CommonResponse ChangeStatus(HrServiceRequest NewService);
        CommonResponse RemoveserviceRequest(int redata);
        CommonResponse UpdateServiceApproval(int serviceid, int Stid, int Empid, string StRem);
        CommonResponse GetAllApprovedServiceData(int EmpName, DateTime DateFrom, DateTime DateTo, long companyId, int typeId, int serviceReqStatus);


    }
}
