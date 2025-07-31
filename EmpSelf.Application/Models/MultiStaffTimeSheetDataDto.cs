using EmpSelf.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
    public class MultiStaffTimeSheetDataDto
    {
        public int TimesheetDataId { get; set; }
        public int? TimesheetId { get; set; }
        public long? TimesheetDataStaffID { get; set; }
        public long? TimesheetDataProjectId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }

        //public virtual HrEmpTimesheets Timesheet { get; set; }
        public virtual HrProjects TimesheetDataProject { get; set; }
        public virtual HrStaffMaster TimesheetDataStaff { get; set; }
    }
}
