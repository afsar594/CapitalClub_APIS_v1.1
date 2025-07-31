using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrNationality
    {
        public HrNationality()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long NationalityId { get; set; }
        public string Nationality { get; set; }
        public long? SortOrder { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
