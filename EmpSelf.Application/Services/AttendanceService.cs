using EmpSelf.Application.Models;
using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace EmpSelf.Application.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly STContext _context;

        public AttendanceService(STContext context)
        {
            _context = context;     
        }
        public CommonResponse CHeckIN(CheckINDto1 CheckInData)
        {
            HrAttendaceSheet NewData = new HrAttendaceSheet();

            try
            {

                var lastpunchdata = _context.HrAttendaceSheet
                    .Where(c => c.AttendanceEmpId == CheckInData.empId
                    && c.PunchMode != CheckInData.punchMode && c.Active == true).FirstOrDefault();

                


                byte[] p1 = null;

                if (CheckInData.file != null)
                {
                    using (var fs1 = CheckInData.file.OpenReadStream())
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        p1 = ms1.ToArray();
                    }
                }

                string testd,testd1,testd2;

                //testd = DateTime.Today.ToString();

                testd1 = CheckInData.punchdate.ToString();

                
               // testd1 = testd.Replace("00:00:00", testd2);
                //CheckInData.punchdate;

                NewData.ImageFile=  p1;
                NewData.Latitude = CheckInData.Latitude;
                NewData.Longitude = CheckInData.Longitude;
                NewData.LocationName = CheckInData.LocationName;
                NewData.ProjectId = CheckInData.ProjectID;
                NewData.PunchMode = CheckInData.punchMode;
                NewData.AttendanceEmpId = CheckInData.empId;
                NewData.Remarks = CheckInData.Remarks;
                //  NewData.PunchDate = DateTime.Now;
                NewData.PunchDate = DateTime.Parse(CheckInData.punchdate, CultureInfo.InvariantCulture,DateTimeStyles.AdjustToUniversal);
                ////NewData.PunchDate = CheckInData.punchd
                NewData.Active = true;

                _context.Add(NewData);

                if (lastpunchdata!= null)
                {

                    lastpunchdata.Active = false;
                    _context.Update(lastpunchdata);
                }
                _context.SaveChanges();
                return CommonResponse.Ok();

            }catch(Exception ex)
            {
                return CommonResponse.Error();

            }
        }

        public CommonResponse GetCurrentStatus(long  Empid)
        {
            try
            {
                var Status = _context.HrAttendaceSheet.Where(x =>  x.AttendanceEmpId == Empid && x.Active ==true).OrderBy(x => x.AttendanceId).Include(x=>x.Project).LastOrDefault();
            //if(Status == null)
            //    {
            //       //var lastData =_context.HrAttendaceSheet.Where(x => x.AttendanceEmpId == Empid).OrderBy(x => x.AttendanceId).LastOrDefault();
            //       // if (lastData != null)
            //       // {
            //       //     if (lastData.CheckOut == null)
            //       //     {
            //       //         lastData.CheckOut = "6:00 PM";
            //       //         _context.Update(lastData);
            //       //     }
            //       // }
            //    }
                return CommonResponse.Ok(Status);
            }
            catch(Exception ex)
            {
                return CommonResponse.Error();
            }
        }
    }
}
