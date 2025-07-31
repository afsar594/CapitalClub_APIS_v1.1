using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveMultiStaffDetails
    {
        public long DetLvMulId { get; set; }
        public long? LvMulId { get; set; }
        public long? StaffId { get; set; }
        public long? LeaveId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public double? NoOfDays { get; set; }
        public string Remarks { get; set; }
        public long? LeaveMasterId { get; set; }
    }
}
