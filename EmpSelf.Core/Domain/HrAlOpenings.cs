using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAlOpenings
    {
        public long? Id { get; set; }
        public long? Staffid { get; set; }
        public double? Al { get; set; }
        public string Remarks { get; set; }
        public long? LeaveId { get; set; }
        public DateTime? Uptodate { get; set; }
    }
}
