using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrEmpTimesheetData
    {
        public int TimesheetDataId { get; set; }
        public int? TimesheetId { get; set; }
        public long? TimesheetDataProjectId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        //public DateTimeKind? StartTime { get; set; }
        //public DateTimeKind? EndTime { get; set; }
        public DateTime? EndDate { get; set; }

        //public DateTimeKind
        public string Description { get; set; }

        //public virtual HrEmpTimesheets Timesheet { get; set; }
        public virtual HrProjects TimesheetDataProject { get; set; }
    }
}
