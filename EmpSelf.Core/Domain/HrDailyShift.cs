using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDailyShift
    {
        public long? ShiftId { get; set; }
        public string ShiftName { get; set; }
        public string ShiftCode { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public DateTime? BreakInTime { get; set; }
        public DateTime? BreakOutTime { get; set; }
        public string ShiftType { get; set; }
        public bool? IsNextDay { get; set; }
        public bool? IsPrevDay { get; set; }
        public DateTime? NormWorkHr { get; set; }
        public DateTime? TimeVariation { get; set; }
    }
}
