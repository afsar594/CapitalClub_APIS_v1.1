using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrWorkGroupPermissions
    {
        public long Sno { get; set; }
        public int FormId { get; set; }
        public int WorkGroupId { get; set; }
        public bool Uallow { get; set; }
        public bool Uadd { get; set; }
        public bool Uedit { get; set; }
        public bool Udelete { get; set; }
        public bool Uview { get; set; }
        public bool Uprint { get; set; }
    }
}
