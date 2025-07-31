using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetDetailsTime
    {
        public long Sno { get; set; }
        public long? Tsid { get; set; }
        public DateTime? TsdDate { get; set; }
        public long? SiteId { get; set; }
        public double? TotHr { get; set; }
        public double? Ot { get; set; }
        public string Remarks { get; set; }
        public decimal? FromTime { get; set; }
        public decimal? ToTime { get; set; }
        public int? Jobid { get; set; }

        public virtual HrTimeSheetTime Ts { get; set; }
    }
}
