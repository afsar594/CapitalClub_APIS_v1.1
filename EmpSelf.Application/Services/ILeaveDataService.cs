using EmpSelf.Application.Models;
using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
   public interface ILeaveDataService
    {
        CommonResponse NewLeaveRequest(NewLeaveDataDto NewLeaveData);
        CommonResponse UpdateLeaveRequest(HrLeaveDataReq NewLeaveData);
        CommonResponse GetAll(int EmpID);
        CommonResponse GetAllLeaveBal(int EmpID);

        CommonResponse getallstaff();
        
        CommonResponse GetAllLeaveBalType(int EmpID,int Lcode);
        CommonResponse GetCount(int EmpID);
        CommonResponse GetstaffByAdminId(int EmpID,int WorkgroupId);

        
        CommonResponse RemoveLeaveRequest(int leavedata);

        CommonResponse UpdateLeaveApproval(int leavedata,int stid,int Empid, string StRem);
        CommonResponse GetPendingAll(int EmpID);
        CommonResponse GetAllPending(int EmpName, DateTime DateFrom, DateTime DateTo,long companyId);
        CommonResponse GetAllApproved(int EmpName, DateTime DateFrom, DateTime DateTo,long companyId);
        CommonResponse GetFilterData(int EmpID, DateTime? DateFrom, DateTime? DateTo);

        CommonResponse GetDataWithID(int LID);

        CommonResponse GetCompanies();
        CommonResponse GetAllLeaveBalance( int empid, int workgroupid);
        //  CommonResponse RemoveLeaveRequest(HrLeaveDataReq NewLeaveData);




    }
}
