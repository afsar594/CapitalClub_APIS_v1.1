using EmpSelf.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
   public class TimesheetDataDto
    {
        public int TimesheetDataId { get; set; }
        public int? TimesheetId { get; set; }
        public long? TimesheetDataProjectId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }

        //public virtual HrEmpTimesheets Timesheet { get; set; }
        public virtual HrProjects TimesheetDataProject { get; set; }
    }
}
