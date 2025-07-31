using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrCampMaster
    {
        public long CmpId { get; set; }
        public string Camp { get; set; }
        public long? LocationId { get; set; }
        public double? Capacity { get; set; }
        public double? Amount { get; set; }
        public DateTime? CmpDate { get; set; }
    }
}
