using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrWeekDays
    {
        public string WeekDays { get; set; }
        public int? OrderByNo { get; set; }
        public string DayType { get; set; }
    }
}
