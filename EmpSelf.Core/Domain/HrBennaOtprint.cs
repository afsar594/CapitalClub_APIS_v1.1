using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrBennaOtprint
    {
        public long? Id { get; set; }
        public long? StaffId { get; set; }
        public double? Othr { get; set; }
        public string DayStatus { get; set; }
        public DateTime? TsDate { get; set; }
        public long? SiteId { get; set; }
        public double? NormalHr { get; set; }
        public double? NormalHramt { get; set; }
        public double? Othramt { get; set; }
    }
}
