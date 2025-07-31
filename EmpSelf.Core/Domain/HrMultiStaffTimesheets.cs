using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrMultiStaffTimesheets
    {
        ////////public HrMultiStaffTimesheets()
        ////////{
        ////////    HrMultiStaffTimesheetData = new HashSet<HrMultiStaffTimesheetData>();
        ////////}

        ////public int TimesheetId { get; set; }
        ////public DateTime? Timesheetdate { get; set; }
        ////public int? Employee { get; set; }
        ////public DateTime? Created { get; set; }
        ////public int? createdby { get; set; }
        ////public int? Status { get; set; }

        ////////public virtual ICollection<HrMultiStaffTimesheetData> HrMultiStaffTimesheetData { get; set; }
        ///

        ////public HrMultiStaffTimesheets()
        ////{
        ////    HrMultiStaffTimesheetData = new HashSet<HrMultiStaffTimesheetData>();
        ////}

        ////public int TimesheetId { get; set; }
        ////public DateTime? Timesheetdate { get; set; }
        ////public long? CompanyId { get; set; }
        ////public int? Employee { get; set; }
        ////public DateTime? Created { get; set; }
        ////public int? Createdby { get; set; }
        ////public int? Status { get; set; }

        ////public virtual ICollection<HrMultiStaffTimesheetData> HrMultiStaffTimesheetData { get; set; }
        ////}

        public HrMultiStaffTimesheets()
        {
            HrMultiStaffTimesheetData = new HashSet<HrMultiStaffTimesheetData>();
        }

        public int TimesheetId { get; set; }
        public DateTime? Timesheetdate { get; set; }
        public long? CompanyId { get; set; }
        public int? Employee { get; set; }
        public DateTime? Created { get; set; }
        public int? Createdby { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<HrMultiStaffTimesheetData> HrMultiStaffTimesheetData { get; set; }
    }
}
