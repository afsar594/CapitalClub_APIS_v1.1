using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class BreakTime
    {
        public int Breakid { get; set; }
        public int? BreakCheckinId { get; set; }
        public string BreakTime1 { get; set; }
        public string BreakEndTime { get; set; }
        public string BreakComment { get; set; }
        public DateTime? Updated { get; set; }
        public int? Active { get; set; }

        public virtual HrAttendaceSheet BreakCheckin { get; set; }
    }
}
