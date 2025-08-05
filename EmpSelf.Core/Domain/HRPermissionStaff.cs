using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HRPermissionStaff
    {
        public long? StaffID { get; set; }
        public int? Priority { get; set; }
        public string ActiveStatus { get; set; }
    }
}
