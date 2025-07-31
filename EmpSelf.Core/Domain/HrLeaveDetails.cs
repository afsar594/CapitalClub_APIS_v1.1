using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveDetails
    {
        public decimal Id { get; set; }
        public long? Lvmid { get; set; }
        public long? StaffId { get; set; }
        public DateTime? SwipeDate { get; set; }
        public string AttCode { get; set; }
        public long? Lcode { get; set; }

        public virtual HrLeaveMaster Lvm { get; set; }
    }
}
