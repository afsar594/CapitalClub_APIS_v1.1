using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrIncrementMaster
    {
        public long Id { get; set; }
        public long? StaffId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Remarks { get; set; }
        public bool? Status { get; set; }
    }
}
