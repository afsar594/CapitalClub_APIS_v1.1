using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpSelf.Application.Services
{
    public class LeaveDataType : ILeaveDataType
    {
        private readonly STContext _context;
        public LeaveDataType(STContext context)
        {
            _context = context;

        }
        public CommonResponse GetLeaveType()
        {
            try
            {
                return CommonResponse.Ok(_context.HrLeaveType.ToList());
            }
            catch
            {
                return CommonResponse.Error();
            }
        }
        //public CommonResponse GetAllUsers()
        //{
        //    try
        //    {
        //        _context.HrStaffMaster.ToList();
        //        return CommonResponse.Ok(_context.HrUsers.ToList());
        //    }
        //    catch
        //    {
        //        return CommonResponse.Error();
        //    }
        //}
        public CommonResponse GetAllUsers()
        {
            try
            {
                var result = (from u in _context.HrUsers
                              join s in _context.HrStaffMaster
                              on u.UserId equals s.StaffId
                              select new
                              {
                                  u.UserId,
                                  u.UserName,
                                  Passwd = u.Passwd,         // assuming column is Passwd
                                  u.StaffName,
                                  s.StaffCode,
                                  s.CompanyId
                              }).ToList();

                return CommonResponse.Ok(result);
            }
            catch
            {
                return CommonResponse.Error();
            }
        }

        public CommonResponse GetLeaveTypebyID(int userID)
        {
            try
            {
                // Get user info with company ID
                var userInfo = (from u in _context.HrUsers
                                join sm in _context.HrStaffMaster on u.UserId equals sm.StaffId
                                where u.UserId == userID
                                select new { sm.CmpId, u.UserId })
                              .FirstOrDefault();

                List<HrLeaveType> leaveTypes = userInfo.CmpId == 2
                    ? _context.HrLeaveType


                        .Where(lt => new[] { 12, 14, 27 }.Contains((int)lt.LeaveID))
                        .ToList()
                    : _context.HrLeaveType
                        .Where(lt => !(new[] { 12, 14 }.Contains((int)lt.LeaveID)))
                        .ToList();

                return CommonResponse.Ok(leaveTypes);
            }
            catch (Exception ex)
            {
                return CommonResponse.Error($"An error occurred: {ex.Message}");
            }
        }
    }
}
