using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrShiftMemberAllocation
    {
        public long Id { get; set; }
        public long? ShiftId { get; set; }
        public long? MemberId { get; set; }
        public DateTime? ShiftDate { get; set; }
        public long? ShiftTypeId { get; set; }

        public virtual HrStaffMaster Member { get; set; }
        public virtual HrTimeTable Shift { get; set; }
    }
}
