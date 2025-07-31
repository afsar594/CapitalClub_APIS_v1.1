using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrShifts
    {
        public long ShiftId { get; set; }
        public string ShiftName { get; set; }
        public double? NormalHr { get; set; }
    }
}
