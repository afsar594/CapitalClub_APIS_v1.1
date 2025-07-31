using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveMultiStaffMaster
    {
        public long? LvMulId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Remarks { get; set; }
    }
}
