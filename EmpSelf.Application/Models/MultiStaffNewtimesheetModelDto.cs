using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
    //public class Root
    //{
    //    //public string[]> Result { get; set; }
    //}
    public class MultiStaffNewtimesheetModelDto
    {
        public DateTime TimesheetDate { get; set; }
        public int empID { get; set; }
        public string[][] TimesheetData { get; set; }
    }
    public class MultiStaffTimesheetData
    {
        public MultiStaffTimesheetDataProject MultiStaffTimesheetDataProject { get; set; }
        public MultiStaffTimesheetDataStaff MultiStaffTimesheetDataStaff { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }

    }
    public class MultiStaffTimesheetDataProject
    {
        public string ProjectName { get; set; }
    }

    public class MultiStaffTimesheetDataStaff
    {
        public string StaffName { get; set; }
    }
}
