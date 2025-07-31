using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheet
    {
        public HrTimeSheet()
        {
            HrTimeSheetDetails = new HashSet<HrTimeSheetDetails>();
        }

        public long Tsid { get; set; }
        public DateTime? Tsdate { get; set; }
        public long? StaffId { get; set; }
        public long? MonthId { get; set; }
        public long? Tsyear { get; set; }
        public string Remarks { get; set; }
        public double? TotHr { get; set; }
        public double? HolHr { get; set; }
        public double? Othr { get; set; }

        public virtual ICollection<HrTimeSheetDetails> HrTimeSheetDetails { get; set; }
    }
}
