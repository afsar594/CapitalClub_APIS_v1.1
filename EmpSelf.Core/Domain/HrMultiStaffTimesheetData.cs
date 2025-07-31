using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrMultiStaffTimesheetData
    {
        //////public int TimesheetDataId { get; set; }
        //////public int? TimesheetId { get; set; }
        //////public long? TimesheetDataStaffId { get; set; }
        //////public long? TimesheetDataProjectId { get; set; }
        //////public TimeSpan? StartTime { get; set; }
        //////public TimeSpan? EndTime { get; set; }
        //////public DateTime? EndDate { get; set; }
        //////public string Description { get; set; }

        //////////public virtual HrMultiStaffTimesheets Timesheet { get; set; }
        //////////public virtual HrProjects MultiStaffTimesheetDataProject { get; set; }
        //////////public virtual HrStaffMaster MultiStaffTimesheetDataStaff { get; set; }
        ///

        public int TimesheetDataId { get; set; }
        public int? TimesheetId { get; set; }
        public long? TimesheetDataStaffId { get; set; }
        public long? TimesheetDataProjectId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }

        public virtual HrMultiStaffTimesheets Timesheet { get; set; }
        public virtual HrProjects TimesheetDataProject { get; set; }
        public virtual HrStaffMaster TimesheetDataStaff { get; set; }
    }
}
