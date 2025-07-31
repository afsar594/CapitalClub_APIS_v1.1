using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrUserTracking
    {
        public decimal Usno { get; set; }
        public string Vpno { get; set; }
        public string Vptype { get; set; }
        public long UserId { get; set; }
        public string Vpaction { get; set; }
        public decimal Fsno { get; set; }
        public DateTime ChangeDt { get; set; }
        public DateTime ChangeTime { get; set; }
        public int? StaffId { get; set; }
        public string Remarks { get; set; }
    }
}
