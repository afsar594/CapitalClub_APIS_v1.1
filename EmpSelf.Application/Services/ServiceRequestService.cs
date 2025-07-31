using EmpSelf.Application.Models;
using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.ComponentModel.Design;

namespace EmpSelf.Application.Services
{
    public class ServiceRequestService : IServiceRequestService
    {
        private readonly STContext _context;
        public ServiceRequestService(STContext context)
        {
            _context = context;
        }

        CultureInfo ci = new CultureInfo("en-US");

        public CommonResponse AddNewServiceReq(NewServiceRequest NewService)
        {
            try
            {
                HrServiceRequest NewREQ = new HrServiceRequest()
                {

                    ServiceReqEmp = NewService.ServiceReqEmp,
                    ServiceReqDate = NewService.Reqdate.Value.AddDays(1),
                    ServiceReqStatus = 0,
                    ServiceReqType = NewService.serviceType.ServiceReqTypeId,
                    ServiceReqReason = NewService.ServiceReqReason,
                    ServiceStaffReview = NewService.ServiceStaffReview,
                    CompanyName =null,
                    hruser =null
                    
                };
                this._context.HrServiceRequest.Add(NewREQ);
                this._context.SaveChanges();
                return CommonResponse.Created(NewService);
            }
            catch
            {
                return CommonResponse.Error();
            }
        }

        public CommonResponse ChangeStatus(HrServiceRequest NewService)
        {
            try
            {
                this._context.HrServiceRequest.Add(NewService);
                this._context.SaveChanges();
                return CommonResponse.Created(NewService);
            }
            catch
            {
                return CommonResponse.Error();
            }
        }

        public CommonResponse GetServiceRequest(int EMPID)
        {
            try
            {
                var Res = _context.HrServiceRequest.Where(x => x.ServiceReqEmp == EMPID).Include(x => x.ServiceReqTypeNavigation)
                    .Select(
                    x => new
                    {

                        serviceReqDate = x.ServiceReqDate.Value.ToString("dd/MMM/yyyy", ci),
                        x.ServiceReqId,
                        x.ServiceReqStatus,
                        x.ServiceReqType,
                        x.ServiceReqReason,
                        x.ServiceReqTypeNavigation,

                    }
                    ).ToList();
                return CommonResponse.Ok(Res);
            }
            catch
            {
                return CommonResponse.Error();
            }
        }

        public CommonResponse GetFilterData(int EmpID, DateTime? DateFrom, DateTime? DateTo)
        {

            var Res = (from sr in _context.HrServiceRequest.Include(x => x.ServiceReqTypeNavigation)
                           //.Where(x => x.ServiceReqEmp == EmpID).Where(x => (x.ServiceReqDate >= DateFrom && x.ServiceReqDate <= DateTo))//.OrderByDescending(x => x.ServiceReqId).Include(x => x.ServiceReqTypeNavigation)
                       join sm in _context.HrStaffMaster on (long)sr.ServiceReqEmp equals sm.StaffId
                       join cm in _context.HrCompanyMaster on (long)sm.CompanyId equals cm.CompanyId
                       where sr.ServiceReqEmp == EmpID && ((DateFrom == null || sr.ServiceReqDate >= DateFrom) && (DateTo == null || sr.ServiceReqDate <= DateTo))

                       select new ServiceRequestViewModel
                       {
                           ServiceReqDate = sr.ServiceReqDate,//.Value.ToString("dd/MMM/yyyy", ci),
                           ServiceReqId = sr.ServiceReqId,
                           ServiceReqStatus = sr.ServiceReqStatus,
                           ServiceReqType = sr.ServiceReqType,
                           ServiceReqReason = sr.ServiceReqReason,
                           ServiceReqTypeNavigation = sr.ServiceReqTypeNavigation,
                           CompanyName = cm.CompanyName,
                           ServiceStaffReview = sr.ServiceStaffReview

                       }).OrderByDescending(x => x.ServiceReqDate).ToList();
            //foreach(var hrs in Res)
            //{
            //    hrs.ServiceReqDate = hrs.ServiceReqDate.Value.ToString("dd/MMM/yyyy", ci);
            //}
            //var Res = _context.HrServiceRequest.Where(x => x.ServiceReqEmp == EmpID).Where(x => (x.ServiceReqDate >= DateFrom && x.ServiceReqDate <= DateTo)).OrderByDescending(x => x.ServiceReqId).Include(x => x.ServiceReqTypeNavigation)

            //        .Select(
            //        x => new
            //        {

            //            serviceReqDate = x.ServiceReqDate.Value.ToString("dd/MMM/yyyy", ci),
            //            x.ServiceReqId,
            //            x.ServiceReqStatus,
            //            x.ServiceReqType,
            //            x.ServiceReqReason,
            //            x.ServiceReqTypeNavigation,

            //        }
            //        ).OrderByDescending(x => x.serviceReqDate).ToList();


            return CommonResponse.Ok(Res);
        }

        public CommonResponse GetServiceRequestById(int SID)
        {
            try
            {
                var Res = _context.HrServiceRequest.Where(x => x.ServiceReqId == SID).Include(x => x.ServiceReqTypeNavigation)
                    .Select(
                    x => new
                    {

                        serviceReqDate = x.ServiceReqDate.Value.ToString("dd/MMM/yyyy", ci),
                        x.ServiceReqId,
                        x.ServiceReqStatus,
                        x.ServiceReqType,
                        x.ServiceReqTypeNavigation,
                        x.ServiceReqAprovImg,
                        x.ServiceReqReason,

                    }
                    ).ToList();
                return CommonResponse.Ok(Res);
            }
            catch
            {
                return CommonResponse.Error();
            }
        }

        public CommonResponse GetStaffById(int EmpID)
        {
            try
            {
                var Res = _context.HrStaffMaster.Where(x => x.StaffId == EmpID)
                    .Select(
                    x => new
                    {

                        Doj = x.Doj.Value.ToString("dd/MMM/yyyy", ci),
                        x.StaffId,
                        //x.StaffCode,
                        //x.StaffTypeId,
                        //x.StatusChangeDate,
                        //x.MaritalStatus

                    }
                    ).FirstOrDefault();
                return CommonResponse.Ok(Res);
            }
            catch
            {
                return CommonResponse.Error();
            }
        }
        public CommonResponse GetAllServiceRequest(int EmpName, DateTime DateFrom, DateTime DateTo, long companyID,int typeId)
        {

                var Res = (from sr in _context.HrServiceRequest
                            join sm in _context.HrStaffMaster on sr.ServiceReqEmp equals sm.StaffId
                            join cm in _context.HrCompanyMaster on sm.CompanyId equals cm.CompanyId

                       where
                     (sr.ServiceReqStatus == 1 || sr.ServiceReqStatus == 0) 
                        && (sm.ActiveStatusId == 0 || sm.ActiveStatusId == 1)
                                 && (companyID == -1 || cm.CompanyId == companyID)
                                   && (EmpName == -1 || sm.StaffId == EmpName) 
                                    && (typeId == -1 || sr.ServiceReqType == typeId) &&

                     (DateFrom == new DateTime(1900, 01, 01).Date || sr.ServiceReqDate >= DateFrom) &&
                     (DateTo == new DateTime(2080, 01, 01).Date || sr.ServiceReqDate <= DateTo)

                           select new HrServiceRequest
                    {
                        ServiceReqDate = sr.ServiceReqDate,//Value.ToString("dd/MMM/yyyy", ci),
                        ServiceReqId = sr.ServiceReqId,
                        ServiceReqStatus = sr.ServiceReqStatus ?? null,
                        ServiceReqType = sr.ServiceReqType ?? null,
                        ServiceReqReason = sr.ServiceReqReason ?? null,
                        ServiceReqTypeNavigation = sr.ServiceReqTypeNavigation ?? null,
                        CompanyName = cm.CompanyName ?? "",
                        ServiceStaffReview = sr.ServiceStaffReview?? "",
                        hruser = _context.HrStaffMaster.Where(m => m.StaffId == sr.ServiceReqEmp.Value).FirstOrDefault().FullName ?? null

                    }).ToList();

                   return CommonResponse.Ok(Res);
                  }

        public CommonResponse GetAllApprovedServiceData(int EmpName, DateTime DateFrom, DateTime DateTo, long companyID, int typeId,int serviceReqStatus)
        {

            var Res = (from sr in _context.HrServiceRequest
                       join sm in _context.HrStaffMaster on sr.ServiceReqEmp equals sm.StaffId
                       join cm in _context.HrCompanyMaster on sm.CompanyId equals cm.CompanyId

                       where
                     (serviceReqStatus == -1 || sr.ServiceReqStatus == serviceReqStatus)
                        && (sm.ActiveStatusId == 0 || sm.ActiveStatusId == 1)
                                 && (companyID == -1 || cm.CompanyId == companyID)
                                   && (EmpName == -1 || sm.StaffId == EmpName)
                                    && (typeId == -1 || sr.ServiceReqType == typeId) &&

                     (DateFrom == new DateTime(1900, 01, 01).Date || sr.ServiceReqDate >= DateFrom) &&
                     (DateTo == new DateTime(2080, 01, 01).Date || sr.ServiceReqDate <= DateTo)

                       select new HrServiceRequest
                       {
                           ServiceReqDate = sr.ServiceReqDate,//Value.ToString("dd/MMM/yyyy", ci),
                           ServiceReqId = sr.ServiceReqId,
                           ServiceReqStatus = sr.ServiceReqStatus ?? null,
                           ServiceReqType = sr.ServiceReqType ?? null,
                           ServiceReqReason = sr.ServiceReqReason ?? null,
                           ServiceReqTypeNavigation = sr.ServiceReqTypeNavigation ?? null,
                           CompanyName = cm.CompanyName ?? "",
                           ServiceStaffReview = sr.ServiceStaffReview ?? "",
                           hruser = _context.HrStaffMaster.Where(m => m.StaffId == sr.ServiceReqEmp.Value).FirstOrDefault().FullName ?? null

                       }).ToList();

            return CommonResponse.Ok(Res);
        }


        public CommonResponse UpdateServiceApproval(int redata, int stid,int Empid,string StRem)
        {
            try
            {
                var data = _context.HrServiceRequest.Where(x => x.ServiceReqId == redata).FirstOrDefault();
                if (data != null)
                {
                   
                        data.ServiceReqApproveDate = DateTime.Now;
                        data.ServiceReqApprovedBy = Empid;
                        data.ServiceReqStatus = stid;
                        data.ServiceReqRemarks = StRem;
                        this._context.HrServiceRequest.Update(data);
                        this._context.SaveChanges();
                    return CommonResponse.Created(data);
                }

                //else
                //{
                //return CommonResponse.Error();
                //}



            }
            catch(Exception ex)
            {
                throw ex;
                //return CommonResponse.Error();
            }
            return CommonResponse.Error();
        }


        public CommonResponse RemoveserviceRequest(int redata)
        {
            try
            {
                var data = _context.HrServiceRequest.Where(x => x.ServiceReqId == redata).FirstOrDefault();
                if (data == null) return CommonResponse.Error();

                if (data.ServiceReqStatus == 0 || data.ServiceReqStatus == 1)
                {
                    this._context.HrServiceRequest.Remove(data);
                    this._context.SaveChanges();
                }
                else
                {
                    return CommonResponse.Error();
                }
                return CommonResponse.Created(data);

            }
            catch
            {
                return CommonResponse.Error();
            }

        }
    }
}
