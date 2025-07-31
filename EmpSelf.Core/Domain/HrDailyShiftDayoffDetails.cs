using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDailyShiftDayoffDetails
    {
        public int Id { get; set; }
        public long? ShiftId { get; set; }
        public long? DayId { get; set; }
        public bool? DayOff { get; set; }
    }
}
