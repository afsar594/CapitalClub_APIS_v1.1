using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrSkillDetails
    {
        public long SkId { get; set; }
        public long? DesigId { get; set; }
        public long? Sno { get; set; }
        public long? StaffId { get; set; }
        public string SkillName { get; set; }
    }
}
