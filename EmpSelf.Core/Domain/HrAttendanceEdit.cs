using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAttendanceEdit
    {
        public long? Id { get; set; }
        public long? AttLogId { get; set; }
        public long? StaffId { get; set; }
        public DateTime? PunchDate { get; set; }
        public int? InOutMode { get; set; }
        public DateTime? InOutTime { get; set; }
        public DateTime? ActualInOutTime { get; set; }
        public string Remarks { get; set; }
        public bool? IsEdit { get; set; }
        public int? MachineId { get; set; }
        public int? WorkCode { get; set; }
        public long? CreateUser { get; set; }
        public long? ShiftId { get; set; }
    }
}
