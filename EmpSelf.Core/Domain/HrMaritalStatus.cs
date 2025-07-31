using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrMaritalStatus
    {
        public HrMaritalStatus()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long MaritalStatusId { get; set; }
        public string MaritalStatus { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
