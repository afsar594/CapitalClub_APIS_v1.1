using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetTime
    {
        public HrTimeSheetTime()
        {
            HrTimeSheetDetailsTime = new HashSet<HrTimeSheetDetailsTime>();
        }

        public long Tsid { get; set; }
        public DateTime? Tsdate { get; set; }
        public long? StaffId { get; set; }
        public long? MonthId { get; set; }
        public long? Tsyear { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<HrTimeSheetDetailsTime> HrTimeSheetDetailsTime { get; set; }
    }
}
