using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    ////public partial class HrProjects
    ////{
    ////    public HrProjects()
    ////    {
    ////        //HrAttendaceSheet = new HashSet<HrAttendaceSheet>();
    ////     //   HrEmpTimesheetData = new HashSet<HrEmpTimesheetData>();
    ////    }

    ////    public long ProjectId { get; set; }
    ////    public string ProjectName { get; set; }
    ////    public int? Active { get; set; }

    ////    //public virtual ICollection<HrAttendaceSheet> HrAttendaceSheet { get; set; }
    ////  //  public virtual ICollection<HrEmpTimesheetData> HrEmpTimesheetData { get; set; }
    ////}
    ///

    public partial class HrProjects
    {
        public HrProjects()
        {
            HrMultiStaffTimesheetData = new HashSet<HrMultiStaffTimesheetData>();
        }

        public long ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? Active { get; set; }

        public virtual ICollection<HrMultiStaffTimesheetData> HrMultiStaffTimesheetData { get; set; }
    }

}
