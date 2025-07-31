using EmpSelf.Application.Models;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
    public interface IMultiStaffTimeSheetService
    {
        CommonResponse AddNewMultiStaffTimesheet(MultiStaffNewtimesheetModelDto Newdata);
        CommonResponse GetProjects();
        CommonResponse GetStaff();
        CommonResponse GetMultiStaffTimesheets(int Empid, int year = 0, int month = 0);
        CommonResponse  GetMultiStaffTimesheetsData(int timesheetid);
        CommonResponse GetMultiStaffTimesheetsByDate(DateTime timesheetDate, int empid, bool flag);
        CommonResponse GetCurrentMultiStaffTimesheets(int empid);
    }
}
