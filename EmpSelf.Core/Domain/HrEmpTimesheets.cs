using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrEmpTimesheets
    {
        public HrEmpTimesheets()
        {
            //HrEmpTimesheetData = new HashSet<HrEmpTimesheetData>();
        }

        public int TimesheetId { get; set; }
        public DateTime? Timesheetdate { get; set; }
        public int? Employee { get; set; }
        public DateTime? Created { get; set; }
        public int? Status { get; set; }

        //public virtual ICollection<HrEmpTimesheetData> HrEmpTimesheetData { get; set; }
    }
}
