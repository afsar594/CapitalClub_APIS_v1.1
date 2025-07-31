using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAttendaceSheet
    {
        public HrAttendaceSheet()
        {
            BreakTime = new HashSet<BreakTime>();
        }

        public int AttendanceId { get; set; }
        public long AttendanceEmpId { get; set; }
        public long ProjectId { get; set; }
        public DateTime? PunchDate { get; set; }
        public string CheckOut { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string LocationName { get; set; }
        public byte[] ImageFile { get; set; }
        public string Remarks { get; set; }
        public bool? PunchMode { get; set; }
        public bool? Active { get; set; }

        public virtual HrUsers AttendanceEmp { get; set; }
        public virtual HrProjects Project { get; set; }
        public virtual ICollection<BreakTime> BreakTime { get; set; }
    }
}
