using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetTimeBrk
    {
        public long Tsid { get; set; }
        public DateTime? Tsdate { get; set; }
        public long? StaffId { get; set; }
        public long? MonthId { get; set; }
        public long? Tsyear { get; set; }
        public string Remarks { get; set; }
        public double? NorOt { get; set; }
        public double? HolOt { get; set; }
        public double? TotOt { get; set; }
    }
}
