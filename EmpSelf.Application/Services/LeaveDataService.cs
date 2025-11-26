using EmpSelf.Application.EmailNotifications;
using EmpSelf.Application.Models;
using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EmpSelf.Application.Services
{
    public class LeaveDataService : ILeaveDataService
    {
        private readonly STContext _context;
        //private ICollection<HrAddress> HrAddress;
        //private ICollection<HrUsers> HrUsers;
        //private readonly ICollection<HrUsers> _hrUsers;
        //private ICollection<HrLeaveType> HrLeaveType;
        //private ICollection<HrStaffMaster> HrStaffMaster;
        private readonly IEmailNotificationServices _emailNotificationServices;
        private readonly ApplicationMailSettings _mailSettings;
        public LeaveDataService(STContext context, IEmailNotificationServices emailNotificationServices, IOptions<ApplicationMailSettings> options)
        {
            _context = context;
            _emailNotificationServices = emailNotificationServices;
            _mailSettings = options.Value;
            //_hrUsers = hrUsers;

        }

        CultureInfo ci = new CultureInfo("en-US");
        public CommonResponse GetAllLeaveBalance(int empid, int workgroupId, int departmentId)
        {
            // Fetch all leave balances along with corresponding staff and company details using a join

            if (workgroupId == 1)
            {
                var leaveBalances = (from leave in _context.HrLeaveBalance
                                     join staff in _context.HrStaffMaster
                                     on leave.LeaveBalUserid equals staff.StaffId
                                     join user in _context.HrUsers
                                     on leave.LeaveBalUserid equals user.UserId
                                     join company in _context.HrCompanyMaster
                                     on staff.CompanyId equals company.CompanyId
                                     join dept in _context.HrDepartment
                                     on staff.DepartmentId equals dept.DepartmentId
                                     where (departmentId == -1 || dept.DepartmentId == departmentId)
                                     //where staff.ActiveStatusId == "Annual Leave"
                                     select new LeaveBalanaceViewModel
                                     {
                                         TotalLeaveBalance = leave.LeaveBalNo,
                                         StaffId = leave.LeaveBalUserid,
                                         StaffCode = staff.StaffCode,
                                         FullName = staff.FullName,
                                         JoiningDate = staff.Doj,
                                         CompanyName = company.CompanyName,
                                         DepartmentName = dept.Department,
                                         DepartmentId = dept.DepartmentId,

                                         LeaveType = leave.LeaveBalType
                                     }).ToList();
                return CommonResponse.Ok(leaveBalances);
            }
            else
            {
                var leaveBalances = (from leave in _context.HrLeaveBalance
                                     join staff in _context.HrStaffMaster
                                     on leave.LeaveBalUserid equals staff.StaffId
                                     join user in _context.HrUsers
                                     on leave.LeaveBalUserid equals user.UserId
                                     join company in _context.HrCompanyMaster
                                     on staff.CompanyId equals company.CompanyId
                                     join dept in _context.HrDepartment
                                     on staff.DepartmentId equals dept.DepartmentId
                                     //where leave.LeaveBalType == "Annual Leave"
                                     where (user.WorkgroupId == workgroupId && user.UserId == empid
                                     &&
                                    (departmentId == -1 || dept.DepartmentId == departmentId))

                                     select new LeaveBalanaceViewModel
                                     {
                                         TotalLeaveBalance = leave.LeaveBalNo,
                                         StaffId = leave.LeaveBalUserid,
                                         StaffCode = staff.StaffCode,
                                         FullName = staff.FullName,
                                         JoiningDate = staff.Doj,
                                         CompanyName = company.CompanyName,
                                         DepartmentName = dept.Department,
                                         DepartmentId = dept.DepartmentId,
                                         LeaveType = leave.LeaveBalType
                                     }).ToList();
                return CommonResponse.Ok(leaveBalances);
            }

            // Return the response with the list of leave balance view models

        }



        public CommonResponse GetAll(int EmpID)
        {
            var data = _context.HrLeaveDataReq.Where(x => x.LeaveEmpid == EmpID)
                .Include(x => x.LeaveDataTypeNavigation)
                .Where(x => (x.LeaveDataFrom < DateTime.Now && x.LeaveDataTo > DateTime.Now) || (x.LeaveDataFrom > DateTime.Now && x.LeaveDataTo > DateTime.Now))
                .OrderByDescending(x => x.LeavDataId)
                .Select(x => new LeaveReqViewModel()
                {
                    LeaveDataFrom = Convert.ToDateTime(x.LeaveDataFrom).ToString("dd/MMMM/yyyy", ci),
                    LeaveDataTo = Convert.ToDateTime(x.LeaveDataTo).ToString("dd/MMMM/yyyy", ci),
                    LeaveDataReason = x.LeaveDataReason,
                    ReqDate = x.ReqDate,
                    ApproveDate = x.ApproveDate,
                    ApprovedBy = x.ApprovedBy,
                    RejectedDate = x.RejectedDate,
                    RejectedBy = x.RejectedBy,
                    Remarks = x.Remarks,
                    LeaveDataTypeNavigation = x.LeaveDataTypeNavigation,
                    LeaveDays = x.LeaveDays,
                    Status = x.Status,
                    LeavDataId = x.LeavDataId
                }).ToList();
            //foreach (var drows in data)
            //{
            //    LeaveReqViewModel newRow = new LeaveReqViewModel()
            //    {
            //        LeaveDataFrom = Convert.ToDateTime(drows.LeaveDataFrom).ToString("dd/MMMM/yyyy", ci),
            //        LeaveDataTo = Convert.ToDateTime(drows.LeaveDataTo).ToString("dd/MMMM/yyyy", ci),
            //        LeaveDataReason = drows.LeaveDataReason,
            //        ReqDate = drows.ReqDate,
            //        ApproveDate = drows.ApproveDate,
            //        ApprovedBy = drows.ApprovedBy,
            //        RejectedDate = drows.RejectedDate,
            //        RejectedBy = drows.RejectedBy,
            //        Remarks = drows.Remarks,
            //        LeaveDataTypeNavigation = drows.LeaveDataTypeNavigation,
            //        LeaveDays = drows.LeaveDays,
            //        Status = drows.Status,
            //        LeavDataId = drows.LeavDataId
            //    };

            //    Leavedata.Add(newRow);

            //}
            //;
            ////Leavedata = Leavedata.OrderByDescending(x => x.ReqDate);
            return CommonResponse.Ok(data);
        }

        public CommonResponse GetAllLeaveBal(int EmpID)
        {
            var data = _context.HrLeaveBalance
                        .Where(x => x.LeaveBalUserid == EmpID)
                        .OrderByDescending(x => x.LeaveBalCode)
                        .Select(x=> new LeaveBalviewModel() {
                            LeaveBalId = x.LeaveBalId,
                            LeaveBalCode = x.LeaveBalCode,
                            LeaveBalType = x.LeaveBalType,
                            LeaveBalUserid = x.LeaveBalUserid,
                            LeaveBalNo = x.LeaveBalNo
                        })
                        .ToList();

            //foreach (var drows in data)
            //{
            //    LeaveBalviewModel newRow = new LeaveBalviewModel()
            //    {
            //        LeaveBalId = drows.LeaveBalId,
            //        LeaveBalCode = drows.LeaveBalCode,
            //        LeaveBalType = drows.LeaveBalType,
            //        LeaveBalUserid = drows.LeaveBalUserid,
            //        LeaveBalNo = drows.LeaveBalNo
            //    };

            //    LeaveBaldata.Add(newRow);
            //}
            //;
            return CommonResponse.Ok(data);
        }
        public CommonResponse getallstaff()
        {
            var data = _context.HrStaffMaster.Where(x => x.ActiveStatusId == 1 || x.ActiveStatusId == 0).ToList();



            return CommonResponse.Ok(data);
        }
        public CommonResponse getalldepartment()
        {
            var data = _context.HrDepartment
                .Select(x => new DepartmentViewModel()
                {
                    DepartmentId = x.DepartmentId,
                    Department = x.Department
                }).OrderBy(x => x.Department).ToList();



            return CommonResponse.Ok(data);
        }

        public CommonResponse GetstaffByAdminId(int id, int WorkgroupId)
        {
            if (WorkgroupId == 1)
            {
                var result = (from staff in _context.HrStaffMaster
                              join user in _context.HrUsers
                                  on staff.StaffId equals user.UserId
                              where staff.SuperVisorId == id &&
                                    (staff.ActiveStatusId == 1 || staff.ActiveStatusId == 0)
                              select new
                              {
                                  Staff = staff,
                                  User = user
                              }).ToList();

                return CommonResponse.Ok(result);
            }
            else
            {
                var data = _context.HrStaffMaster.Where(x => x.ActiveStatusId == 1 || x.ActiveStatusId == 0).ToList();
                return CommonResponse.Ok(data);
            }
        }


        public CommonResponse GetAllLeaveBalType(int EmpID, int Lcode)
        {
            var data = _context.HrLeaveBalance
                .Where(x => x.LeaveBalUserid == EmpID && x.LeaveBalCode == Lcode)
                .Select(x=> new LeaveBalviewModel()
                {
                    LeaveBalId = x.LeaveBalId,
                    LeaveBalCode = x.LeaveBalCode,
                    LeaveBalType = x.LeaveBalType,
                    LeaveBalUserid = x.LeaveBalUserid,
                    LeaveBalNo = x.LeaveBalNo
                })
                .OrderByDescending(x => x.LeaveBalCode)
                .ToList();
            //foreach (var drows in data)
            //{
            //    LeaveBalviewModel newRow = new LeaveBalviewModel()
            //    {
            //        LeaveBalId = drows.LeaveBalId,
            //        LeaveBalCode = drows.LeaveBalCode,
            //        LeaveBalType = drows.LeaveBalType,
            //        LeaveBalUserid = drows.LeaveBalUserid,
            //        LeaveBalNo = drows.LeaveBalNo
            //    };

            //    LeaveBaldata.Add(newRow);

            //}
            //;
            return CommonResponse.Ok(data);
        }

        public CommonResponse GetCount(int EmpID)
        {
            CountModel CountModel = new CountModel();
            var data = _context.HrLeaveDataReq.Where(c => c.LeaveEmpid == EmpID).Select(
                x => x.Status).ToList();
            CountModel.Approval = data.Count(x => x.Value == 1);
            CountModel.Pending = data.Count(x => x.Value == 0);
            var servicedata = _context.HrServiceRequest.Where(c => c.ServiceReqEmp == EmpID).Select(
                x => x.ServiceReqStatus).ToList();
            CountModel.ServiceApproval = servicedata.Count(x => x.Value == 0);
            CountModel.ServicePending = servicedata.Count(x => x.Value == 1);
            return CommonResponse.Ok(CountModel);
        }

        public CommonResponse GetFilterData(int EmpID, DateTime? DateFrom, DateTime? DateTo)
        {

            var Res = (from drows in _context.HrLeaveDataReq.Include(x => x.LeaveDataTypeNavigation)
                           //.Where(x => x.ServiceReqEmp == EmpID).Where(x => (x.ServiceReqDate >= DateFrom && x.ServiceReqDate <= DateTo))//.OrderByDescending(x => x.ServiceReqId).Include(x => x.ServiceReqTypeNavigation)
                       join sm in _context.HrStaffMaster on (long)drows.LeaveEmpid equals sm.StaffId
                       join cm in _context.HrCompanyMaster on (long)sm.CompanyId equals cm.CompanyId
                       where drows.LeaveEmpid == EmpID && ((DateFrom == null || drows.LeaveDataFrom >= DateFrom) && (DateTo == null || drows.LeaveDataTo <= DateTo))
                       select new LeaveReqViewModel
                       {
                           LeaveDataFrom = Convert.ToDateTime(drows.LeaveDataFrom).ToString("dd/MMM/yyyy", ci),
                           LeaveDataTo = Convert.ToDateTime(drows.LeaveDataTo).ToString("dd/MMM/yyyy", ci),
                           LeaveDataReason = drows.LeaveDataReason,
                           ReqDate = drows.ReqDate,
                           ApproveDate = drows.ApproveDate,
                           ApprovedBy = drows.ApprovedBy,
                           RejectedDate = drows.RejectedDate,
                           RejectedBy = drows.RejectedBy,
                           Remarks = drows.Remarks,
                           LeaveDataTypeNavigation = drows.LeaveDataTypeNavigation,
                           LeaveDays = drows.LeaveDays,
                           Status = drows.Status,
                           LeavDataId = drows.LeavDataId,
                           CompanyName = cm.CompanyName,
                           Remaining = _context.HRLeaveApprovalStaffdetails.Where(x => x.ApproveStatus != 2 && x.LeaveID == drows.LeavDataId).Count(),
                       }).OrderByDescending(x => x.LeavDataId).ToList();

            return CommonResponse.Ok(Res);

            //var data = _context.HrLeaveDataReq.Where(x => x.LeaveEmpid == EmpID)
            //    .Include(x => x.LeaveDataTypeNavigation)
            //    .Where(x => (x.LeaveDataFrom >= DateFrom && x.LeaveDataTo <= DateTo))
            //    .OrderByDescending(x => x.LeavDataId).ToList();


            //foreach (var drows in data)
            //{
            //    LeaveReqViewModel newRow = new LeaveReqViewModel()
            //    {
            //        LeaveDataFrom = Convert.ToDateTime(drows.LeaveDataFrom).ToString("dd/MMM/yyyy", ci),
            //        LeaveDataTo = Convert.ToDateTime(drows.LeaveDataTo).ToString("dd/MMM/yyyy", ci),
            //        LeaveDataReason = drows.LeaveDataReason,
            //        ReqDate = drows.ReqDate,
            //        ApproveDate = drows.ApproveDate,
            //        ApprovedBy =drows.ApprovedBy,
            //        RejectedDate = drows.RejectedDate,
            //        RejectedBy = drows.RejectedBy,
            //        Remarks = drows.Remarks,
            //        LeaveDataTypeNavigation = drows.LeaveDataTypeNavigation,
            //        LeaveDays = drows.LeaveDays,
            //        Status = drows.Status,
            //        LeavDataId = drows.LeavDataId
            //    };

            //    Leavedata.Add(newRow);

            //};
            //return CommonResponse.Ok(Leavedata);
        }


        public CommonResponse GetDataWithID(int LevID)
        {
            var data = _context.HrLeaveDataReq
                .Where(x => x.LeavDataId == LevID && (x.Status == 0 || x.Status == 1))
                .Include(x => x.LeaveDataTypeNavigation)
                .Select(x => new LeaveReqViewModel()
                {
                    LeaveDataFrom = Convert.ToDateTime(x.LeaveDataFrom).ToString("dd/MMM/yyyy", ci),
                    LeaveDataTo = Convert.ToDateTime(x.LeaveDataTo).ToString("dd/MMM/yyyy", ci),
                    LeaveDataReason = x.LeaveDataReason,
                    ReqDate = x.ReqDate,
                    ApproveDate = x.ApproveDate,
                    ApprovedBy = x.ApprovedBy,
                    RejectedDate = x.RejectedDate,  
                    RejectedBy = x.RejectedBy,
                    Remarks = x.Remarks,
                    LeaveDataTypeNavigation = x.LeaveDataTypeNavigation,
                    LeaveDays = x.LeaveDays,
                    Status = x.Status,
                    LeavDataId = x.LeavDataId,
                    LeaveReqImage = x.LeaveReqImage
                });
            //foreach (var drows in data)
            //{
            //    LeaveReqViewModel newRow = new LeaveReqViewModel()
            //    {
            //        LeaveDataFrom = Convert.ToDateTime(drows.LeaveDataFrom).ToString("dd/MMM/yyyy", ci),
            //        LeaveDataTo = Convert.ToDateTime(drows.LeaveDataTo).ToString("dd/MMM/yyyy", ci),
            //        LeaveDataReason = drows.LeaveDataReason,
            //        ReqDate = drows.ReqDate,
            //        ApproveDate = drows.ApproveDate,
            //        ApprovedBy = drows.ApprovedBy,
            //        RejectedDate = drows.RejectedDate,
            //        RejectedBy = drows.RejectedBy,
            //        Remarks = drows.Remarks,
            //        LeaveDataTypeNavigation = drows.LeaveDataTypeNavigation,
            //        LeaveDays = drows.LeaveDays,
            //        Status = drows.Status,
            //        LeavDataId = drows.LeavDataId,
            //        LeaveReqImage = drows.LeaveReqImage
            //    };

            //    Leavedata.Add(newRow);

            //}
            //;
            return CommonResponse.Ok(data);
        }



        public CommonResponse GetPendingAll(int EmpID)
        {
            var data = _context.HrLeaveDataReq.Where(x => x.LeaveEmpid == EmpID && x.Status == 0 && x.LeaveDataFrom > DateTime.Now)
                                .Include(x => x.LeaveDataTypeNavigation)

                .Select(x => new LeaveDataViewModel()
                {
                    LeaveDataFrom = Convert.ToDateTime(x.LeaveDataFrom).ToString("dd/MMM/yyyy", ci),
                    LeaveDataTo = Convert.ToDateTime(x.LeaveDataTo).ToString("dd/MMM/yyyy", ci),
                    LeaveDays = x.LeaveDays,
                    LeavDataId = x.LeavDataId,
                    LeaveDataReason = x.LeaveDataReason,
                    LeaveDataType = x.LeaveDataType,
                    LeaveDataTypeNavigation = x.LeaveDataTypeNavigation

                })
                .ToList();
            // return CommonResponse.Ok();
            return CommonResponse.Ok(data);
        }


        public CommonResponse GetAllPending(int EmpName, DateTime DateFrom, DateTime DateTo, long companyId)
        {



            var data = (from hr in _context.HrLeaveDataReq

                        join st in _context.HrStaffMaster on hr.LeaveEmpid equals st.StaffId
                        join cm in _context.HrCompanyMaster on st.CompanyId equals cm.CompanyId


                        where
                         (hr.Status == 0) && (st.ActiveStatusId == 0 || st.ActiveStatusId == 1)
                                    //(hr.Status == 2 || hr.Status == 3) && (st.ActiveStatusId == 0 || st.ActiveStatusId == 1)
                                    && (companyId == -1 || cm.CompanyId == companyId)
                                     && (EmpName == -1 || st.StaffId == EmpName) &&

                         (DateFrom == new DateTime(1900, 01, 01).Date || hr.LeaveDataFrom >= DateFrom) &&
                         (DateTo == new DateTime(2080, 01, 01).Date || hr.LeaveDataTo <= DateTo)


                        select new LeaveDataViewModel
                        {
                            LeaveDataFrom = Convert.ToDateTime(hr.LeaveDataFrom).ToString("dd/MMM/yyyy", ci),
                            LeaveDataTo = Convert.ToDateTime(hr.LeaveDataTo).ToString("dd/MMM/yyyy", ci),
                            LeaveDays = hr.LeaveDays ?? 0,
                            LeavDataId = hr.LeavDataId,
                            ReqDate = Convert.ToDateTime(hr.ReqDate),
                            LeaveDataReason = hr.LeaveDataReason ?? null,
                            LeaveDataType = hr.LeaveDataType ?? null,
                            Status = hr.Status ?? null,
                            LeaveDataTypeNavigation = hr.LeaveDataTypeNavigation ?? null,
                            LeaveEmp = hr.LeaveEmp ?? null,
                            CompanyName = cm.CompanyName ?? null,
                            LeaveEmpName = st.FullName ?? null
                        }).ToList();


            return CommonResponse.Ok(data);
        }



        public CommonResponse GetAllApproved(int EmpName, DateTime DateFrom, DateTime DateTo, long companyId)
        {

            var data = (from hr in _context.HrLeaveDataReq.Include(x => x.LeaveDataTypeNavigation).Include(x => x.LeaveEmp)

                        join st in _context.HrStaffMaster on hr.LeaveEmpid equals st.StaffId
                        join cm in _context.HrCompanyMaster on st.CompanyId equals cm.CompanyId

                        where
                (hr.Status == 2 || hr.Status == 3) && (st.ActiveStatusId == 0 || st.ActiveStatusId == 1)
                    && (companyId == -1 || cm.CompanyId == companyId)
                     && (EmpName == -1 || st.StaffId == EmpName) &&

                 (DateFrom == new DateTime(1900, 01, 01).Date || hr.LeaveDataFrom >= DateFrom) &&
                 (DateTo == new DateTime(2080, 01, 01).Date || hr.LeaveDataTo <= DateTo)

                        select new LeaveDataViewModel
                        {
                            LeaveDataFrom = hr.LeaveDataFrom.HasValue
                         ? hr.LeaveDataFrom.Value.ToString("dd/MMM/yyyy", ci)
                         : null,
                            LeaveDataTo = hr.LeaveDataTo.HasValue
                         ? hr.LeaveDataTo.Value.ToString("dd/MMM/yyyy", ci)
                         : null,
                            LeaveDays = hr.LeaveDays,
                            LeavDataId = hr.LeavDataId,
                            ReqDate = hr.ReqDate.HasValue ? hr.ReqDate.Value : default,
                            LeaveDataReason = hr.LeaveDataReason,
                            LeaveDataType = hr.LeaveDataType,
                            Status = hr.Status,
                            LeaveDataTypeNavigation = hr.LeaveDataTypeNavigation,
                            LeaveEmp = hr.LeaveEmp,
                            CompanyName = cm.CompanyName,
                            LeaveEmpName = st != null ? st.FullName : null,
                            Remaining = _context.HRLeaveApprovalStaffdetails.Where(x => x.ApproveStatus != 2 && x.LeaveID == hr.LeavDataId).Count(),
                        }).ToList();


            return CommonResponse.Ok(data);

        }
        public CommonResponse getalllHolidaysbyDate(DateTime DateFrom, DateTime DateTo)
        {
            var count = _context.HrCompanyCalender
                .Where(c => c.Mdate >= DateFrom && c.Mdate <= DateTo &&
                            (c.Mday == "F" || c.Mday == "H"))
                .Count();

            return CommonResponse.Ok(count);
        }

        public async Task<CommonResponse> NewLeaveRequest(NewLeaveDataDto NewLeaveData)
        {
            try
            {
                //var user = _context.HrUsers.Where(c => c.UserId == NewLeaveData.EmployeeID).FirstOrDefault();
                var user =
               (
                   from lm in _context.HrLeaveDataReq

                   join lt in _context.HrLeaveType
                       on lm.LeaveDataType equals lt.LeaveTypeId into ltJoin
                   from lt in ltJoin.DefaultIfEmpty()

                   join s in _context.HrStaffMaster
                       on lm.LeaveEmpid equals s.StaffId into sJoin
                   from s in sJoin.DefaultIfEmpty()

                   join a in _context.HrAddress
                       on lm.LeaveEmpid equals a.StaffId into aJoin
                   from a in aJoin.DefaultIfEmpty()

                   join u in _context.HrUsers
                       on lm.LeaveEmpid equals u.UserId into uJoin
                   from u in uJoin.DefaultIfEmpty()

                   where lm.LeaveEmpid == NewLeaveData.EmployeeID
                   orderby lm.LeavDataId descending

                   select new
                   {
                       FullName = s.FullName,
                       LeaveType = lt.LeaveType,
                       LeaveDataFrom = lm.LeaveDataFrom,
                       LeaveDataTo = lm.LeaveDataTo,
                       LeaveDays = lm.LeaveDays,
                       Email = a.Email,
                       Reason = lm.LeaveDataReason,
                       UserName = u.UserName,
                       UserId = u.UserId
                   }
               )
               .FirstOrDefault();


                if (user == null)
                {
                    return CommonResponse.Error();
                }

                ////var maxcount = 1234;
                //var maxcount = Convert.ToInt32(
                //_context.HrLeaveDataReq.AsQueryable().DefaultIfEmpty().Max(o => o == null ? 0 : o.LeavDataId + 1));

                byte[] p1 = null;

                if (NewLeaveData.imageFile != null)
                {
                    p1 = Convert.FromBase64String(NewLeaveData.imageFile.Split(',')[1]);
                    ////using (var fs1 = NewLeaveData.imageFile.OpenReadStream())
                    ////using (var ms1 = new MemoryStream())
                    ////{
                    ////    fs1.CopyTo(ms1);
                    ////    p1 = ms1.ToArray();
                    ////}
                }



                HrLeaveDataReq LeaveDataReq = new HrLeaveDataReq()



                {
                    LeaveDataFrom = NewLeaveData.FromDate.AddDays(0),
                    LeaveDataTo = NewLeaveData.EndDate.AddDays(0),
                    LeaveDataReason = NewLeaveData.Reason,
                    LeaveDays = NewLeaveData.TotalDays,
                    ReqDate = DateTime.Now,
                    //LeavDataId = maxcount,
                    LeaveEmpid = user.UserId,
                    LeaveDataType = NewLeaveData.LeaveType.LeaveTypeId,
                    Status = 0,
                    LeaveReqImage = p1
                };

                this._context.HrLeaveDataReq.Add(LeaveDataReq);
                this._context.SaveChanges();
                HRLeaveApprovalStaffdetails LeaveSD = new HRLeaveApprovalStaffdetails()

                {
                    LeaveID = LeaveDataReq.LeavDataId,
                    PermissionStaffID = 1,
                    ApproveStatus = 0,

                };
                this._context.HRLeaveApprovalStaffdetails.Add(LeaveSD);
                HRLeaveApprovalStaffdetails LeaveSD1 = new HRLeaveApprovalStaffdetails()

                {
                    LeaveID = LeaveDataReq.LeavDataId,
                    PermissionStaffID = 2,
                    ApproveStatus = 0,

                };
                this._context.HRLeaveApprovalStaffdetails.Add(LeaveSD1);
                HRLeaveApprovalStaffdetails LeaveSD2 = new HRLeaveApprovalStaffdetails()

                {
                    LeaveID = LeaveDataReq.LeavDataId,
                    PermissionStaffID = 3,
                    ApproveStatus = 0,

                };



                #region Email Notification 

                var toMail = new List<SendGrid.Helpers.Mail.EmailAddress>() {
                   // new SendGrid.Helpers.Mail.EmailAddress("jaanjayaraj@gmail.com", "Jinash"),
                new SendGrid.Helpers.Mail.EmailAddress(user?.Email?? "",user?.FullName ?? ""),                };

                //var users = _hrUsers.AsQueryable().FirstOrDefault(e => e.UserId == LeaveDataReq.LeaveEmpid);
                var users = _context.HrUsers.AsQueryable().FirstOrDefault(e => e.UserId == LeaveDataReq.LeaveEmpid);
                
                string leaveTypeName = GetLeaveTypeName((int)LeaveDataReq.LeaveDataType);

                var dynomicTemplateData = new
                {
                    EmployeeName = users.StaffName,
                    LeaveType = leaveTypeName,
                    FromDate = Convert.ToDateTime(LeaveDataReq.LeaveDataFrom).ToShortDateString(),
                    ToDate = Convert.ToDateTime(LeaveDataReq.LeaveDataTo).ToShortDateString(),
                    TotalDays = LeaveDataReq.LeaveDays,
                    Reason = LeaveDataReq.Remarks ?? "",
                    ApprovalLink = ""
                };
                await _emailNotificationServices.SendSingleTemplateEmailToMultipleRecipientsAsync(toMail, _mailSettings.TemplateId, dynomicTemplateData);

                #endregion



                this._context.HRLeaveApprovalStaffdetails.Add(LeaveSD2);
                this._context.SaveChanges();
                return CommonResponse.Created(NewLeaveData);
            }
            catch (Exception ex)
            {
                return CommonResponse.Error();
            }
        }
        public string GetLeaveTypeName(int leaveTypeId)
        {
            return leaveTypeId switch
            {
                1 => "Annual Leave",
                2 => "Absent Half Day",
                3 => "Emergency",
                5 => "Absent",
                6 => "Sick Leave",
                7 => "Remote Work",
                _ => ""
            };
        }
        public CommonResponse RemoveLeaveRequest(int leavedata)
        {
            try
            {

                var data = _context.HrLeaveDataReq.Where(x => x.LeavDataId == leavedata).FirstOrDefault();
                if (data == null) return CommonResponse.Error();

                int remaining = _context.HRLeaveApprovalStaffdetails.Where(x => x.ApproveStatus != 2 && x.LeaveID == leavedata).Count();

                if (remaining < 3)
                {
                    return CommonResponse.Error("Approved leaves can't be deleted");
                }

                if (data.Status == 0 || data.Status == 1)
                {
                    this._context.HrLeaveDataReq.Remove(data);
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

        public CommonResponse UpdateLeaveApproval(int leavedata, int stid, int Empid, string StRem)
        {
            try
            {
                var data = _context.HrLeaveDataReq.Where(x => x.LeavDataId == leavedata).FirstOrDefault();
                if (data.Status == 0 || data.Status == 1)
                {
                    if (stid == 2)
                    {
                        data.ApproveDate = DateTime.Now;
                        data.ApprovedBy = Empid;
                    }
                    else
                    {
                        data.RejectedDate = DateTime.Now;
                        data.RejectedBy = Empid;
                    }
                    data.Status = stid;
                    data.Remarks = StRem;
                    this._context.HrLeaveDataReq.Update(data);
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


        public CommonResponse UpdateLeaveMultiApproval(int leavedata, int stid, int Empid, string StRem)
        {
            try
            {
                var data = _context.HrLeaveDataReq.Where(x => x.LeavDataId == leavedata).FirstOrDefault();

                var dataLeaveSt = _context.HRLeaveApprovalStaffdetails.Where(x => x.LeaveID == leavedata && x.PermissionStaffID == Empid).FirstOrDefault();

                //if (data.Status == 0 || data.Status == 1)
                //{
                //    if (stid == 2)
                //    {
                //        data.ApproveDate = DateTime.Now;
                //        data.ApprovedBy = Empid;
                //    }
                //    else
                //    {
                //        data.RejectedDate = DateTime.Now;
                //        data.RejectedBy = Empid;
                //    }
                //    data.Status = stid;
                //    data.Remarks = StRem;
                //    this._context.HrLeaveDataReq.Update(data);
                //    this._context.SaveChanges();
                //}
                //else
                //{
                //    return CommonResponse.Error();
                //}

                if (dataLeaveSt != null)
                {
                    dataLeaveSt.ApproveStatus = 2;
                    dataLeaveSt.Remarks = StRem;
                    this._context.HrLeaveDataReq.Update(data);
                    this._context.SaveChanges();
                }
                return CommonResponse.Created(data);

            }
            catch
            {
                return CommonResponse.Error();
            }

        }
        public CommonResponse UpdateLeaveRequest(HrLeaveDataReq NewLeaveData)
        {
            try
            {
                this._context.HrLeaveDataReq.Update(NewLeaveData);
                this._context.SaveChanges();
                return CommonResponse.Created(NewLeaveData);
            }
            catch
            {
                return CommonResponse.Error();
            }
        }
        public CommonResponse GetMultiAllPending(int EmpName, DateTime DateFrom, DateTime DateTo,
      long companyId, long userId)
        {

            var data = (from hr in _context.HrLeaveDataReq.Include(x => x.LeaveDataTypeNavigation).Include(x => x.LeaveEmp)

                        join st in _context.HrStaffMaster on hr.LeaveEmpid equals st.StaffId
                        join cm in _context.HrCompanyMaster on st.CompanyId equals cm.CompanyId
                        join sd in _context.HRLeaveApprovalStaffdetails on hr.LeavDataId equals sd.LeaveID

                        where
                     //(hr.Status == 2 || hr.Status == 3) &&
                     //&& (st.ActiveStatusId == 0 || st.ActiveStatusId == 1)
                     //&& (companyId == -1 || cm.CompanyId == companyId)
                     // && (EmpName == -1 || st.StaffId == EmpName) &&
                     sd.PermissionStaffID == userId &&
                 (DateFrom == new DateTime(1900, 01, 01).Date || hr.LeaveDataFrom >= DateFrom) &&
                 (DateTo == new DateTime(2080, 01, 01).Date || hr.LeaveDataTo <= DateTo)

                        select new LeaveDataViewModel
                        {
                            LeaveDataFrom = hr.LeaveDataFrom.HasValue
                         ? hr.LeaveDataFrom.Value.ToString("dd/MMM/yyyy", ci)
                         : null,
                            LeaveDataTo = hr.LeaveDataTo.HasValue
                         ? hr.LeaveDataTo.Value.ToString("dd/MMM/yyyy", ci)
                         : null,
                            LeaveDays = hr.LeaveDays,
                            LeavDataId = hr.LeavDataId,
                            ReqDate = hr.ReqDate.HasValue ? hr.ReqDate.Value : default,
                            LeaveDataReason = hr.LeaveDataReason,
                            LeaveDataType = hr.LeaveDataType,
                            Status = sd.ApproveStatus,
                            LeaveDataTypeNavigation = hr.LeaveDataTypeNavigation,
                            LeaveEmp = hr.LeaveEmp,
                            CompanyName = cm.CompanyName,
                            LeaveEmpName = st != null ? st.FullName : null,
                            Remaining = _context.HRLeaveApprovalStaffdetails.Where(x => x.ApproveStatus != 2 && x.LeaveID == hr.LeavDataId).Count(),
                        }).ToList();



            return CommonResponse.Ok(data);

        }


        public CommonResponse GetCompanies()
        {
            var companies = _context.HrCompanyMaster

                    .Select(x => new CompnanyDataViewModel()
                    {
                        Id = x.CompanyId,
                        Name = x.CompanyName
                    }).OrderBy(x => x.Name)
                .ToList();
            return CommonResponse.Ok(companies);
        }
    }
}
