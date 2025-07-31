using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetMulStaff
    {
        public long Tsid { get; set; }
        public DateTime? TsDate { get; set; }
        public long? MonthId { get; set; }
        public long? Tsyear { get; set; }
        public string Remarks { get; set; }

        public virtual HrTimeSheetMulStaffDetails HrTimeSheetMulStaffDetails { get; set; }
    }
}
