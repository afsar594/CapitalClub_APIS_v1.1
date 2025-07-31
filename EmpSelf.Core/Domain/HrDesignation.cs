using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDesignation
    {
        public HrDesignation()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long DesignationId { get; set; }
        public string Designation { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
