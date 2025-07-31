using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrVisaDesignation
    {
        public HrVisaDesignation()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long VisaDesignationId { get; set; }
        public string VisaDesignation { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
