
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
using System.Globalization;
using System.Text.Json;

namespace EmpSelf.Application.Services
{
    public class MultiStaffTimeSheetService : IMultiStaffTimeSheetService
    {
        private readonly STContext _context;
        private ICollection<HrMultiStaffTimesheetData> EmpTimesheetDatas;
        private bool DataFlag;

        public MultiStaffTimeSheetService(STContext context)
        {
            data = new List<HrMultiStaffTimesheets>();
            _context = context;
            this.EmpTimesheetDatas = new List<HrMultiStaffTimesheetData>();
            this.DataFlag = true;
        }
        public CommonResponse AddNewMultiStaffTimesheet(MultiStaffNewtimesheetModelDto Newdata)
        {
            try
            {
                var TimehseetID = 0;
                var timesheetData = _context.HrMultiStaffTimesheets.Where(x => x.Timesheetdate == Newdata.TimesheetDate.AddDays(0)).FirstOrDefault();
                if (timesheetData == null)
                {
                    HrMultiStaffTimesheets EMPTSHEET = new HrMultiStaffTimesheets()
                    {
                        Created = DateTime.Now,
                        Employee = Newdata.empID,
                        Status = 1,
                        Timesheetdate = Newdata.TimesheetDate.AddDays(0),
                    };
                    _context.Add(EMPTSHEET);
                    _context.SaveChanges();
                    TimehseetID = EMPTSHEET.TimesheetId;
                }
                else
                {
                    var d =   _context.HrMultiStaffTimesheetData.Where(x => x.TimesheetId == timesheetData.TimesheetId).ToList();
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
                    var ProjectID = _context.HrProjects.Where(c => c.ProjectId.ToString() == rowdata[1].ToString()).Select(c => c.ProjectId).FirstOrDefault();
                    if (ProjectID == null || ProjectID == 0) this.DataFlag = false;
                    var StaffID = _context.HrStaffMaster.Where(c => c.StaffId.ToString() == rowdata[0].ToString()).Select(c => c.StaffId).FirstOrDefault();
                    if (StaffID == null || StaffID == 0) this.DataFlag = false;
                    DateTime validValue;

                    HrMultiStaffTimesheetData NewRowData = new HrMultiStaffTimesheetData()
                    {
                        Description = rowdata[5],
                        EndTime = Convert.ToDateTime(rowdata[3]).TimeOfDay,
                        StartTime = Convert.ToDateTime(rowdata[2]).TimeOfDay,
                        EndDate = DateTime.TryParse(rowdata[4], out validValue) ? validValue
    : (DateTime?)null,
                        TimesheetDataProjectId = ProjectID,
                        TimesheetDataStaffId = StaffID,
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
            }
            catch (Exception ex)
            {
                return CommonResponse.Error();
            }
        }

        public CommonResponse GetProjects()
        {
            return CommonResponse.Ok(_context.HrProjects.ToList());
        }

        public CommonResponse GetStaff()
        {
            return CommonResponse.Ok(_context.HrStaffMaster.ToList());
        }

        IList<HrMultiStaffTimesheets> data;

        public CommonResponse GetMultiStaffTimesheets(int Empid, int month = 0, int year = 0)
        {
            IList<TreeDto> _NewLists = new List<TreeDto>();
            //  TreeDto _NewList = new TreeDto();
            if (year != 0 && month != 0)
                data = _context.HrMultiStaffTimesheets.Where(c => c.Employee == Empid && c.Timesheetdate.Value.Year == year && c.Timesheetdate.Value.Month == month).ToList();
            else
                data = _context.HrMultiStaffTimesheets.Where(c => c.Employee == Empid).ToList();
            foreach (var row in data)
            {
                TreeDto _NewList = new TreeDto();

                ////var _date = row.Timesheetdate;
                var _date = Convert.ToDateTime(row.Timesheetdate);
                var YEARS = _NewLists.Where(c => c.Year == _date.Year).FirstOrDefault();
                if (YEARS == null)
                {
                    _NewList.Year = _date.Year;
                    _NewList.TreeMonths.Add(MakeMonth(_date, row.TimesheetId));
                    var DAYS = _NewList.TreeMonths.Where(c => c.Month == _date.Month).FirstOrDefault();
                    if (DAYS != null)
                        DAYS.TreeDay.Add(Makeday(_date, row.TimesheetId));
                    _NewLists.Add(_NewList);

                }
                else
                {
                    {

                        var MONTHS = YEARS.TreeMonths.Where(c => c.Month == _date.Month).FirstOrDefault();
                        if (MONTHS == null)
                        {
                            YEARS.TreeMonths.Add(MakeMonth(_date, row.TimesheetId));
                            var MONTHS1 = YEARS.TreeMonths.Where(c => c.Month == _date.Month).FirstOrDefault();

                            MONTHS1.TreeDay.Add(Makeday(_date, row.TimesheetId));
                            // var DAYS = _NewList.TreeMonths.Where(c => c.Month == _date.Month).FirstOrDefault();
                            // DAYS.TreeDay.Add(Makeday(_date, row.TimesheetId));

                        }
                        else
                        {
                            MONTHS.TreeDay.Add(Makeday(_date, row.TimesheetId));
                        }
                    }
                }


                // TreeDto newTree = new TreeDto();


                //return CommonResponse.Ok(_context.HrEmpTimesheets.Where(c=>c.Employee == Empid).ToList());
            }
            return CommonResponse.Ok(_NewLists);
        }

        public TreeDay Makeday(DateTime _date, int TimesheetId)
        {
            CultureInfo ci = new CultureInfo("en-US");
            TreeDay TreeDay = new TreeDay()
            {
                Day = Convert.ToInt32(_date.Day),
                DayName = _date.ToString("dddd",ci),
                TimesheetID = TimesheetId
            };
            return TreeDay;
        }
        public TreeMonth MakeMonth(DateTime _date, int timesheetID)
        {
            CultureInfo ci = new CultureInfo("en-US");
            TreeMonth TreeDay = new TreeMonth()
            {
                Month = Convert.ToInt32(_date.Month),
                MonthName = _date.ToString("MMMM",ci),
            };
            // return ( new TreeMonth { Month = _date.Month, MonthName = _date.ToString("MMMM") });
            //TreeMonth.TreeDay.Add(Makeday(_date, timesheetID));
            return TreeDay;
        }


        public CommonResponse GetMultiStaffTimesheetsData(int timesheetid)
        {
           // List<MultiStaffTimeSheetDataDto> timesheetDtoData = new List<MultiStaffTimeSheetDataDto>();
            var maindata = _context.HrMultiStaffTimesheets.Where(c => c.TimesheetId == timesheetid).FirstOrDefault();

            var data = _context.HrMultiStaffTimesheetData.Include(x => x.TimesheetDataStaff).Include(x => x.TimesheetDataProject)
                .Where(c => c.TimesheetId == timesheetid).AsEnumerable().Select((da) => {
                    var EndTime = da.EndTime.Value.ToString("hh\\:mm");
                    MultiStaffTimeSheetDataDto multistafftimesheetDto = new MultiStaffTimeSheetDataDto()
                    {
                        EndTime = da.EndTime.HasValue ? da.EndTime.Value.ToString("hh\\:mm") : "",
                        StartTime = da.StartTime.HasValue ? da.StartTime.Value.ToString("hh\\:mm") : "",
                        EndDate = da.EndDate.HasValue ? da.EndDate.Value.ToString("dd-MMM-yyyy") : "",
                        Description = da.Description,
                        TimesheetDataId = da.TimesheetDataId,
                        TimesheetDataStaff = da.TimesheetDataStaff,
                        TimesheetDataProject = da.TimesheetDataProject,
                        TimesheetDataProjectId = da.TimesheetDataProjectId,
                        TimesheetDataStaffID = da.TimesheetDataStaffId,
                        TimesheetId = da.TimesheetId
                    };
                    return multistafftimesheetDto;
                }).ToList();
            return CommonResponse.Ok(data);
            ///
            ////var data = _context.HrMultiStaffTimesheetData.Where(c => c.TimesheetId == timesheetid).ToList();
            //var data = _context.HrMultiStaffTimesheetData.Include(x => x.TimesheetDataProjectId).Where(c => c.TimesheetId == timesheetid).ToList();
            //////foreach (var da in data)
            //////{

            ////var ProjName = _context.HrProjects.Where(c => c.ProjectId == da.TimesheetDataProjectId).Select(c => c.ProjectName).FirstOrDefault();
            ////if (ProjName == null || ProjName == " ") ;
            ////var StaffName = _context.HrStaffMaster.Where(c => c.StaffId == da.TimesheetDataStaffId).Select(c => c.FullName).FirstOrDefault();
            ////if (StaffName == null || StaffName == " ");


            //////var EndTime = da.EndTime.Value.ToString("hh\\:mm");
            //////MultiStaffTimeSheetDataDto multistafftimesheetDto = new MultiStaffTimeSheetDataDto()
            //////{
            //////    EndTime = da.EndTime.HasValue ? da.EndTime.Value.ToString("hh\\:mm") : "",
            //////    StartTime = da.StartTime.HasValue ? da.StartTime.Value.ToString("hh\\:mm") : "",
            //////    EndDate = da.EndDate.HasValue ? da.EndDate.Value.ToString("dd-MMM-yyyy") : "",
            //////    Description = da.Description,
            //////    TimesheetDataId = da.TimesheetDataId,
            //////    TimesheetDataStaff = da.TimesheetDataStaff,
            //////    TimesheetDataProject = da.TimesheetDataProject,
            //////    TimesheetDataProjectId = da.TimesheetDataProjectId,
            //////    TimesheetDataStaffID = da.TimesheetDataStaffId,
            //////    TimesheetId = da.TimesheetId
            //////};

            //////timesheetDtoData.Add(multistafftimesheetDto);
            //////}

            ////////////var attandanceData = _context.HrAttendaceSheet.Where(x => x.PunchDate.Value.Date == maindata.Timesheetdate.Value.Date).Include(c => c.Project).ToList();
            ////////////var checkoutflag = false;
            ////////////MultiStaffTimeSheetDataDto timesheetDto1 = new MultiStaffTimeSheetDataDto();
            ////////////var arraycount = 0;
            ////////////foreach (var da in attandanceData)
            ////////////{
            ////////////    arraycount += 1;
            ////////////    if (checkoutflag)
            ////////////    {
            ////////////        if (da.PunchMode == true)
            ////////////        {
            ////////////            timesheetDtoData.Add(timesheetDto1);
            ////////////            timesheetDto1 = new MultiStaffTimeSheetDataDto()
            ////////////            {
            ////////////                EndTime = da.PunchMode.Value == false ? da.PunchDate.Value.ToString("hh\\:mm") : "",
            ////////////                StartTime = da.PunchMode.Value == true ? da.PunchDate.Value.ToString("hh\\:mm") : "",
            ////////////                EndDate = "",

            ////////////                Description = da.Remarks,
            ////////////                TimesheetDataId = da.AttendanceId,
            ////////////                TimesheetDataProject = da.Project,
            ////////////                TimesheetDataProjectId = da.ProjectId,
            ////////////                TimesheetId = da.AttendanceId
            ////////////            };
            ////////////            if (arraycount == attandanceData.Count)
            ////////////                timesheetDtoData.Add(timesheetDto1);
            ////////////        }
            ////////////        else
            ////////////        {
            ////////////            timesheetDto1.Description = timesheetDto1.Description + " --" + da.Remarks;
            ////////////            timesheetDto1.EndTime = da.PunchMode.Value == false ? da.PunchDate.Value.ToString("hh\\:mm") : "";
            ////////////            timesheetDto1.EndDate = "";
            ////////////            timesheetDtoData.Add(timesheetDto1);
            ////////////            checkoutflag = true;
            ////////////        }

            ////////////    }
            ////////////    else
            ////////////    {


            ////////////        timesheetDto1 = new MultiStaffTimeSheetDataDto()
            ////////////        {
            ////////////            EndTime = da.PunchMode.Value == false ? da.PunchDate.Value.ToString("hh\\:mm") : "",
            ////////////            StartTime = da.PunchMode.Value == true ? da.PunchDate.Value.ToString("hh\\:mm") : "",
            ////////////            EndDate = "",
            ////////////            Description = da.Remarks,
            ////////////            TimesheetDataId = da.AttendanceId,
            ////////////            TimesheetDataProject = da.Project,
            ////////////            TimesheetDataProjectId = da.ProjectId,
            ////////////            TimesheetId = da.AttendanceId
            ////////////        };
            ////////////        checkoutflag = true;
            ////////////    }
            ////////////    //if (timesheetDto.EndTime == null) checkoutflag = true;

            ////////////}
            ////checkoutflag = true;
            ////return CommonResponse.Ok(timesheetDtoData);
            ////return data;


            //return CommonResponse.Ok(_context.HrEmpTimesheetData.Include(x => x.TimesheetDataProject).Where(c => c.TimesheetId == timesheetid).ToList());
        }

        public CommonResponse GetMultiStaffTimesheetsByDate(DateTime timesheetDate, int empid, bool flag)
        {
            var timesheet = _context.HrMultiStaffTimesheets.Where(x => x.Timesheetdate == timesheetDate && x.Employee == empid).FirstOrDefault();

           // if (flag == true) return GetMultiStaffTimesheetsData(timesheet.TimesheetId);

            IList<MultiStaffTimeSheetDataDto> timesheetDtoData = new List<MultiStaffTimeSheetDataDto>();

            if (timesheet != null)
            {
                var data = _context.HrMultiStaffTimesheetData.Include(x => x.TimesheetDataStaff).Include(x => x.TimesheetDataProject).Where(c => c.TimesheetId == timesheet.TimesheetId).ToList();
                ////var data = _context.HrMultiStaffTimesheetData.Include(x => x.TimesheetDataProjectId).Where(c => c.TimesheetId == timesheet.TimesheetId).ToList();
                foreach (var da in data)
                {
                    MultiStaffTimeSheetDataDto timesheetDto = new MultiStaffTimeSheetDataDto()
                    {
                        EndTime = da.EndTime.HasValue ? da.EndTime.Value.ToString("hh\\:mm") : "",
                        StartTime = da.StartTime.HasValue ? da.StartTime.Value.ToString("hh\\:mm") : "",
                        EndDate = da.EndDate.HasValue ? da.EndDate.Value.ToString("dd-MMM-yyyy") : "",

                        Description = da.Description,
                        TimesheetDataId = da.TimesheetDataId,
                        TimesheetDataStaff=da.TimesheetDataStaff,
                        TimesheetDataProject = da.TimesheetDataProject,
                        TimesheetDataProjectId = da.TimesheetDataProjectId,
                        TimesheetDataStaffID = da.TimesheetDataStaffId,
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
        public CommonResponse GetCurrentMultiStaffTimesheets(int empid)
        {
            var timesheet = _context.HrMultiStaffTimesheets.Where(x => x.Timesheetdate == DateTime.Now.Date).FirstOrDefault();
            IList<MultiStaffTimeSheetDataDto> timesheetDtoData = new List<MultiStaffTimeSheetDataDto>();

            if (timesheet != null)
            {
                var data = _context.HrMultiStaffTimesheetData.Include(x => x.TimesheetDataStaff).Include(x => x.TimesheetDataProject).Where(c => c.TimesheetId == timesheet.TimesheetId).ToList();
                ////var data = _context.HrMultiStaffTimesheetData.Include(x => x.TimesheetDataProjectId).Where(c => c.TimesheetId == timesheet.TimesheetId).ToList();
                foreach (var da in data)
                {
                    MultiStaffTimeSheetDataDto timesheetDto = new MultiStaffTimeSheetDataDto()
                    {
                        EndTime = da.EndTime.HasValue ? da.EndTime.Value.ToString("hh\\:mm") : "",
                        StartTime = da.StartTime.HasValue ? da.StartTime.Value.ToString("hh\\:mm") : "",
                        EndDate = da.EndDate.HasValue ? da.EndDate.Value.ToString("dd-MMM-yyyy") : "",
                        Description = da.Description,
                        TimesheetDataId = da.TimesheetDataId,
                        TimesheetDataStaff = da.TimesheetDataStaff,
                        TimesheetDataProject = da.TimesheetDataProject,
                        TimesheetDataStaffID = da.TimesheetDataStaffId,
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


    }
}
