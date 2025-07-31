using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrQualification
    {
        public HrQualification()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long QualificationId { get; set; }
        public string Qualification { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
