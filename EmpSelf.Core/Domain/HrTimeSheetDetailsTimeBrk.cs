using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetDetailsTimeBrk
    {
        public long TsidDet { get; set; }
        public long? Sno { get; set; }
        public long? Tsid { get; set; }
        public DateTime? TsdDate { get; set; }
        public bool? DayOff { get; set; }
        public double? MorIn { get; set; }
        public double? MorOut { get; set; }
        public double? AftIn { get; set; }
        public double? AftOut { get; set; }
        public double? RegTime { get; set; }
        public double? NorOt { get; set; }
        public double? HolOt { get; set; }
        public double? Brk1 { get; set; }
        public double? Brk2 { get; set; }
        public double? TotHr { get; set; }
        public string Remarks { get; set; }
        public bool? IsEdit { get; set; }
    }
}
