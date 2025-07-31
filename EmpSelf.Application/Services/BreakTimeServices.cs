using EmpSelf.Application.Models;
using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpSelf.Application.Services
{
   public class BreakTimeServices : IBreakTimeService
    {
        private readonly STContext _context;

        public BreakTimeServices(STContext context)
        {
            _context = context;
        }

        public CommonResponse GetBreakTime(long empid)
        {
            var LastCheckIN = _context.HrAttendaceSheet.Where(x => x.AttendanceEmpId == empid && x.PunchDate == DateTime.Now.Date).OrderBy(x => x.AttendanceId).LastOrDefault();
            if (LastCheckIN != null)
            {
                if (LastCheckIN.CheckOut == null)
                {
                    var LastBreak = _context.BreakTime.Where(x => x.BreakCheckinId == LastCheckIN.AttendanceId).OrderBy(x => x.Breakid).LastOrDefault();
                    return CommonResponse.Ok(LastBreak);

                }
            }
            return CommonResponse.Error();
        }

        public CommonResponse UpdateBreakTime(NewBreakiTimeDto BreakTimeDet)
        {
            BreakTime NewbreakTime = new BreakTime();
            try
            {
                var LastCheckIN = _context.HrAttendaceSheet.Where(x => x.AttendanceEmpId == BreakTimeDet.EmpID && x.PunchDate == DateTime.Now.Date).OrderBy(x => x.AttendanceId).LastOrDefault();
                if(LastCheckIN != null)
                {
                    if(LastCheckIN.CheckOut == null)
                    {
                        var LastBreak = _context.BreakTime.Where(x => x.BreakCheckinId == LastCheckIN.AttendanceId ).OrderBy(x => x.Breakid).LastOrDefault();
                            if(LastBreak == null)
                        {
                            NewbreakTime.BreakCheckinId = LastCheckIN.AttendanceId;
                            NewbreakTime.BreakComment = BreakTimeDet.Comments;
                            NewbreakTime.BreakTime1 = DateTime.Now.ToString("hh:mm tt");
                            NewbreakTime.BreakEndTime = null;
                            NewbreakTime.Updated = DateTime.Now;
                            NewbreakTime.Active = 1;

                            _context.Add(NewbreakTime);
                            _context.SaveChanges();
                            return CommonResponse.Ok(NewbreakTime);

                        }
                        else
                        {
                            if (LastBreak.BreakEndTime != null)
                            {
                                NewbreakTime.BreakCheckinId = LastCheckIN.AttendanceId;
                                NewbreakTime.BreakComment = BreakTimeDet.Comments;
                                NewbreakTime.BreakTime1 = DateTime.Now.ToString("hh:mm tt");
                                NewbreakTime.BreakEndTime = null;
                                NewbreakTime.Updated = DateTime.Now;
                                NewbreakTime.Active = 1;

                                _context.Add(NewbreakTime);
                                _context.SaveChanges();
                                return CommonResponse.Ok(NewbreakTime);

                            }
                            else
                            {
                                LastBreak.BreakEndTime = DateTime.Now.ToShortTimeString();
                                _context.Update(LastBreak);
                                _context.SaveChanges();
                                return CommonResponse.Ok(LastBreak);
                            }
                        }
                    }
                }
                return CommonResponse.Error();

            }
            catch (Exception ex)
            {
                return CommonResponse.Error();
            }
        }
    }
}
