using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetDetails
    {
        public long Sno { get; set; }
        public long? Tsid { get; set; }
        public DateTime? TsdDate { get; set; }
        public long? SiteId { get; set; }
        public double? TotHr { get; set; }
        public double? Ot { get; set; }
        public string Remarks { get; set; }
        public long? ShiftId { get; set; }

        public virtual HrTimeSheet Ts { get; set; }
    }
}
