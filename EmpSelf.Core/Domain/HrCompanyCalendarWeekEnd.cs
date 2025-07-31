using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrCompanyCalendarWeekEnd
    {
        public int DayId { get; set; }
        public string DayNames { get; set; }
        public bool? WeekEnd { get; set; }
    }
}
