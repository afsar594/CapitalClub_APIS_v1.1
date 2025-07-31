using EmpSelf.Application.Models;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
  public  interface ITimesheetService
    {
        CommonResponse AddNewTimesheet(NewtimesheetModelDto Newdata);
        ////CommonResponse UpdateTimesheet(NewtimesheetModelDto Newdata);
        CommonResponse GetProjects();
        CommonResponse GetTimesheets(int Empid, int year = 0, int month = 0);
        CommonResponse GetTimesheetsData(int timesheetid);
        CommonResponse GetTimesheetsByDate(DateTime timesheetDate, int empid, bool flag);
        CommonResponse GetCurrentTimesheets(int empid);

    }
}
