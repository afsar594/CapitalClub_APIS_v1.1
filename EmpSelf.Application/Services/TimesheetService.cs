using EmpSelf.Application.Models;
using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Globalization;

namespace EmpSelf.Application.Services
{
    public class TimesheetService : ITimesheetService
    {
        private readonly STContext _context;
        private ICollection<HrEmpTimesheetData> EmpTimesheetDatas;
        private bool DataFlag;

        public TimesheetService(STContext context)
        {
            data = new List<HrEmpTimesheets>();
            _context = context;
            this.EmpTimesheetDatas = new List<HrEmpTimesheetData>();
            this.DataFlag = true;
        }
        public CommonResponse AddNewTimesheet(NewtimesheetModelDto Newdata)
        {
            try
            {
                var TimehseetID = 0;
                var timesheetData = _context.HrEmpTimesheets.Where(x => x.Timesheetdate == Newdata.TimesheetDate.AddDays(0)).FirstOrDefault();
       //         var timesheetData = _context.HrEmpTimesheets.Where(x => x.Timesheetdate == Newdata.TimesheetDate.Date).FirstOrDefault();
                if (timesheetData == null)
                {
                    HrEmpTimesheets EMPTSHEET = new HrEmpTimesheets()
                    {
                        Created = DateTime.Now,
                        Employee = Newdata.empID,
                        Status = 1,
                        //Timesheetdate = Newdata.TimesheetDate.Date,
                        Timesheetdate = Newdata.TimesheetDate.AddDays(0),
                    };
                    _context.Add(EMPTSHEET);
                    _context.SaveChanges();
                    TimehseetID = EMPTSHEET.TimesheetId;
                }
                else
                {
                  var d=  _context.HrEmpTimesheetData.Where(x => x.TimesheetId == timesheetData.TimesheetId).ToList();
                    _context.RemoveRange(d);
                    _context.SaveChanges();

                    TimehseetID = timesheetData.TimesheetId;
                }

                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                };
                //  var dta = JsonSerializer.Deserialize<string>(Newdata.TimesheetData, options);

                // var dict = JObject.Parse(Newdata.TimesheetData).ToObject<Dictionary<int, List<string>>>();
                foreach (var rowdata in Newdata.TimesheetData)
                {
                   /// var TimeRowID = _context.HrEmpTimesheetData.Where(c => c.TimesheetDataId == rowdata[5]).Select(c => c.ProjectId).FirstOrDefault();
                    var ProjectID = _context.HrProjects.Where(c => c.ProjectId.ToString() == rowdata[0].ToString()).Select(c => c.ProjectId).FirstOrDefault();
                    if (ProjectID == null || ProjectID == 0) this.DataFlag = false;
                    DateTime validValue;

                    HrEmpTimesheetData NewRowData = new HrEmpTimesheetData()
                    {
                        Description = rowdata[4],
                        EndTime = Convert.ToDateTime(rowdata[2]).TimeOfDay,
                        StartTime = Convert.ToDateTime(rowdata[1]).TimeOfDay,
                        ////EndTime = Convert.ToDateTime(rowdata[2]),
                        ////StartTime = Convert.ToDateTime(rowdata[1]),
                        ////EndDate = DateTime.TryParse(rowdata[3], out validValue) ? validValue : (DateTime?)null,   //
                        EndDate = DateTime.TryParse(rowdata[3], out validValue) ? validValue : (DateTime?)DateTime.Now,   //
                        TimesheetDataProjectId = ProjectID,
                        TimesheetId = TimehseetID
                    };
                    this.EmpTimesheetDatas.Add(NewRowData);
                }

                if (this.DataFlag == true)
                {
                    _context.AddRange(this.EmpTimesheetDatas);
                    _context.SaveChanges();
                }
                else
                {
                   // _context.Remove(EMPTSHEET);
                    return CommonResponse.Error();

                }
                return CommonResponse.Ok();
            }catch(Exception ex)
            {
                return CommonResponse.Error();
            }
        }

        public CommonResponse GetProjects()
        {
            return CommonResponse.Ok(_context.HrProjects.ToList());
        }
        IList<HrEmpTimesheets> data;

        public CommonResponse GetTimesheets(int Empid, int month = 0, int year = 0)
        {
            IList<TreeDto> _NewLists = new List<TreeDto>();
         //  TreeDto _NewList = new TreeDto();
         if( year !=0 && month !=0 )
                                 data = _context.HrEmpTimesheets.Where(c => c.Employee == Empid && c.Timesheetdate.Value.Year == year && c.Timesheetdate.Value.Month == month).ToList();
else
             data = _context.HrEmpTimesheets.Where(c => c.Employee == Empid).ToList();
            foreach (var row in data)
            {
                TreeDto _NewList = new TreeDto();

                var _date = row.Timesheetdate;
                var YEARS = _NewLists.Where(c => c.Year == _date.Value.Year).FirstOrDefault();
                if(YEARS == null)
                {
                    _NewList.Year = _date.Value.Year;
                    _NewList.TreeMonths.Add(MakeMonth(_date.Value, row.TimesheetId));
                    var DAYS = _NewList.TreeMonths.Where(c => c.Month == _date.Value.Month).FirstOrDefault();
                    if (DAYS != null)
                    DAYS.TreeDay.Add(Makeday(_date.Value, row.TimesheetId));
                    _NewLists.Add(_NewList);

                }
                else
                {
                    {

                        var MONTHS = YEARS.TreeMonths.Where(c => c.Month == _date.Value.Month).FirstOrDefault();
                        if (MONTHS == null)
                        {
                            YEARS.TreeMonths.Add(MakeMonth(_date.Value, row.TimesheetId));
                            var MONTHS1 = YEARS.TreeMonths.Where(c => c.Month == _date.Value.Month).FirstOrDefault();

                            MONTHS1.TreeDay.Add(Makeday(_date.Value, row.TimesheetId));
                            // var DAYS = _NewList.TreeMonths.Where(c => c.Month == _date.Month).FirstOrDefault();
                            // DAYS.TreeDay.Add(Makeday(_date, row.TimesheetId));

                        }
                        else
                        {
                            MONTHS.TreeDay.Add(Makeday(_date.Value, row.TimesheetId));
                        }
                    }
                }


               // TreeDto newTree = new TreeDto();


                //return CommonResponse.Ok(_context.HrEmpTimesheets.Where(c=>c.Employee == Empid).ToList());
            }
            return CommonResponse.Ok(_NewLists);
        }

        CultureInfo ci = new CultureInfo("en-US");
        public TreeDay Makeday(DateTime _date, int TimesheetId)
        {
            TreeDay TreeDay = new TreeDay()
            {
                Day = Convert.ToInt32(_date.Day),
                DayName = _date.ToString("dddd", ci),
                TimesheetID = TimesheetId
            };
            return TreeDay;
        }
        public TreeMonth MakeMonth(DateTime _date,int timesheetID)
        {
            TreeMonth TreeDay = new TreeMonth()
            {
                Month = Convert.ToInt32(_date.Month),
                MonthName = _date.ToString("MMMM", ci),
            };
           // return ( new TreeMonth { Month = _date.Month, MonthName = _date.ToString("MMMM") });
            //TreeMonth.TreeDay.Add(Makeday(_date, timesheetID));
            return TreeDay;
        }


        public CommonResponse GetTimesheetsData(int timesheetid)
        {
            IList<TimesheetDataDto> timesheetDtoData = new List<TimesheetDataDto>();
            var maindata = _context.HrEmpTimesheets.Where(c => c.TimesheetId == timesheetid).FirstOrDefault();

            var data = _context.HrEmpTimesheetData.Include(x => x.TimesheetDataProject).Where(c => c.TimesheetId == timesheetid).ToList();
                foreach (var da in data)
                {
                var EndTime = da.EndTime.Value.ToString("hh\\:mm");
                    TimesheetDataDto timesheetDto = new TimesheetDataDto()
                    {
                        EndTime = da.EndTime.HasValue ? da.EndTime.Value.ToString("hh\\:mm") : "",
                        StartTime = da.StartTime.HasValue ? da.StartTime.Value.ToString("hh\\:mm") : "",
                        EndDate= da.EndDate,
                        Description = da.Description,
                        TimesheetDataId = da.TimesheetDataId,
                        TimesheetDataProject = da.TimesheetDataProject,
                        TimesheetDataProjectId = da.TimesheetDataProjectId,
                        TimesheetId = da.TimesheetId
                    };

                    timesheetDtoData.Add(timesheetDto);
                }

            var attandanceData = _context.HrAttendaceSheet.Where(x => x.PunchDate.Value.Date == maindata.Timesheetdate.Value.Date).Include(c => c.Project).ToList();
            var checkoutflag = false;
            TimesheetDataDto timesheetDto1 = new TimesheetDataDto();
            var arraycount = 0;
            foreach (var da in attandanceData)
            {
                arraycount += 1;
                if (checkoutflag)
                {
                    if (da.PunchMode == true)
                    {
                        timesheetDtoData.Add(timesheetDto1);
                        timesheetDto1 = new TimesheetDataDto()
                        {
                            EndTime = da.PunchMode.Value == false ? da.PunchDate.Value.ToString("hh\\:mm") : "",
                            StartTime = da.PunchMode.Value == true ? da.PunchDate.Value.ToString("hh\\:mm") : "",
                            EndDate =  null,

                            Description = da.Remarks,
                            TimesheetDataId = da.AttendanceId,
                            TimesheetDataProject = da.Project,
                            TimesheetDataProjectId = da.ProjectId,
                            TimesheetId = da.AttendanceId
                        };
                        if(arraycount == attandanceData.Count)
                            timesheetDtoData.Add(timesheetDto1);
                    }
                    else
                    {
                        timesheetDto1.Description = timesheetDto1.Description + " --" + da.Remarks;
                        timesheetDto1.EndTime = da.PunchMode.Value == false ? da.PunchDate.Value.ToString("hh\\:mm") : "";
                        timesheetDto1.EndDate = null;
                        timesheetDtoData.Add(timesheetDto1);
                        checkoutflag = true;
                    }

                }
                else
                {


                    timesheetDto1 = new TimesheetDataDto()
                    {
                        EndTime = da.PunchMode.Value == false ? da.PunchDate.Value.ToString("hh\\:mm") : "",
                        StartTime = da.PunchMode.Value == true ? da.PunchDate.Value.ToString("hh\\:mm") : "",
                        EndDate = null,
                        Description = da.Remarks,
                        TimesheetDataId = da.AttendanceId,
                        TimesheetDataProject = da.Project,
                        TimesheetDataProjectId = da.ProjectId,
                        TimesheetId = da.AttendanceId
                    };
                    checkoutflag = true;
                }
                //if (timesheetDto.EndTime == null) checkoutflag = true;
                
            }
            return CommonResponse.Ok(timesheetDtoData);


                return CommonResponse.Ok(_context.HrEmpTimesheetData.Include(x=>x.TimesheetDataProject).Where(c => c.TimesheetId == timesheetid).ToList());
        }

        public CommonResponse GetTimesheetsByDate(DateTime timesheetDate, int empid,bool flag )
        {
            var timesheet = _context.HrEmpTimesheets.Where(x => x.Timesheetdate == timesheetDate && x.Employee == empid).FirstOrDefault();

            if (flag == true) return GetTimesheetsData(timesheet.TimesheetId);

            IList<TimesheetDataDto> timesheetDtoData = new List<TimesheetDataDto>();

            if (timesheet != null) {
                var data = _context.HrEmpTimesheetData.Include(x => x.TimesheetDataProject).Where(c => c.TimesheetId == timesheet.TimesheetId).ToList();
                foreach(var da in data)
                {
                    TimesheetDataDto timesheetDto = new TimesheetDataDto()
                    {
                        EndTime = da.EndTime.HasValue ? da.EndTime.Value.ToString("hh\\:mm") : "",
                        StartTime = da.StartTime.HasValue? da.StartTime.Value.ToString("hh\\:mm") : "",
                        EndDate = da.EndDate,

                        Description = da.Description,
                        TimesheetDataId = da.TimesheetDataId,
                        TimesheetDataProject = da.TimesheetDataProject,
                        TimesheetDataProjectId = da.TimesheetDataProjectId,
                        TimesheetId = da.TimesheetId
                    };

                    timesheetDtoData.Add(timesheetDto);
                }


                
                return CommonResponse.Ok(timesheetDtoData);

              //  return CommonResponse.Ok(_context.HrEmpTimesheetData.Include(x => x.TimesheetDataProject).Where(c => c.TimesheetId == timesheet.TimesheetId).ToList());

            }
            else
                return CommonResponse.Ok();

        }
        public CommonResponse GetCurrentTimesheets(int empid)
        {
            var timesheet = _context.HrEmpTimesheets.Where(x => x.Timesheetdate == DateTime.Now.Date && x.Employee==empid).FirstOrDefault();
            IList<TimesheetDataDto> timesheetDtoData = new List<TimesheetDataDto>();

            if (timesheet != null)
            {
                var data = _context.HrEmpTimesheetData.Include(x => x.TimesheetDataProject).Where(c => c.TimesheetId == timesheet.TimesheetId).ToList();
                foreach (var da in data)
                {
                    TimesheetDataDto timesheetDto = new TimesheetDataDto()
                    {
                        EndTime = da.EndTime.HasValue ? da.EndTime.Value.ToString("hh\\:mm") : "",
                        StartTime = da.StartTime.HasValue ? da.StartTime.Value.ToString("hh\\:mm") : "",
                        EndDate = da.EndDate,
                        Description = da.Description,
                        TimesheetDataId = da.TimesheetDataId,
                        TimesheetDataProject = da.TimesheetDataProject,
                        TimesheetDataProjectId = da.TimesheetDataProjectId,
                        TimesheetId = da.TimesheetId
                    };

                    timesheetDtoData.Add(timesheetDto);
                }
                return CommonResponse.Ok(timesheetDtoData);
            }
            else
                return CommonResponse.Ok();

        }


        ////////-----------------------

        //////public CommonResponse UpdateTimesheet(NewtimesheetModelDto Newdata)
        //////{
        //////    try
        //////    {
        //////        var TimehseetID = 0;
        //////        var timesheetData = _context.HrEmpTimesheets.Where(x => x.Timesheetdate == Newdata.TimesheetDate.AddDays(0)).FirstOrDefault();
        //////        //         var timesheetData = _context.HrEmpTimesheets.Where(x => x.Timesheetdate == Newdata.TimesheetDate.Date).FirstOrDefault();
        //////        if (timesheetData == null)
        //////        {
        //////            HrEmpTimesheets EMPTSHEET = new HrEmpTimesheets()
        //////            {

        //////                Created = timesheetData.Created,
        //////                Employee = timesheetData.Employee,
        //////                Status = timesheetData.Status,
        //////                Timesheetdate =timesheetData.Timesheetdate,
        //////                TimesheetId =timesheetData.TimesheetId
        //////            };
        //////            _context.Update (EMPTSHEET);
        //////            _context.SaveChanges();
        //////            TimehseetID = EMPTSHEET.TimesheetId;

        //////            var d = _context.HrEmpTimesheetData.Where(x => x.TimesheetId == TimehseetID).ToList();
        //////            _context.RemoveRange(d);
        //////            _context.SaveChanges();
        //////        }
 
        //////        var options = new JsonSerializerOptions
        //////        {
        //////            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        //////            WriteIndented = true
        //////        };
        //////        //  var dta = JsonSerializer.Deserialize<string>(Newdata.TimesheetData, options);

        //////        // var dict = JObject.Parse(Newdata.TimesheetData).ToObject<Dictionary<int, List<string>>>();
                

        //////        foreach (var rowdata in Newdata.TimesheetData)
        //////        {
                    
        //////            var ProjectID = _context.HrProjects.Where(c => c.ProjectId.ToString() == rowdata[0].ToString()).Select(c => c.ProjectId).FirstOrDefault();
        //////            if (ProjectID == null || ProjectID == 0) this.DataFlag = false;
        //////            DateTime validValue;

        //////            HrEmpTimesheetData NewRowData = new HrEmpTimesheetData()
        //////            {
        //////                Description = rowdata[4],
        //////                EndTime = Convert.ToDateTime(rowdata[2]).TimeOfDay,
        //////                StartTime = Convert.ToDateTime(rowdata[1]).TimeOfDay,
        //////                ////EndTime = Convert.ToDateTime(rowdata[2]),
        //////                ////StartTime = Convert.ToDateTime(rowdata[1]),
        //////                EndDate = DateTime.TryParse(rowdata[3], out validValue) ? validValue : (DateTime?)null,
        //////                TimesheetDataProjectId = ProjectID,
        //////                TimesheetId = TimehseetID
        //////            };

        //////                this.EmpTimesheetDatas.Add(NewRowData);
                  
        //////        }

        //////        if (this.DataFlag == true)
        //////        {
        //////            _context.AddRange(this.EmpTimesheetDatas);
        //////            _context.SaveChanges();
        //////        }
        //////        else
        //////        {
        //////            // _context.Remove(EMPTSHEET);
        //////            return CommonResponse.Error();

        //////        }
        //////        return CommonResponse.Ok();
        //////    }
        //////    catch (Exception ex)
        //////    {
        //////        return CommonResponse.Error();
        //////    }
        //////}

        ////////===========================     
    }

}
