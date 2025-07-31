using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrBloodGroup
    {
        public HrBloodGroup()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long BloodGroupId { get; set; }
        public string BloodGroup { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
