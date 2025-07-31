using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDepartment
    {
        public HrDepartment()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long DepartmentId { get; set; }
        public string Department { get; set; }
        public short? DEleted { get; set; }
        public string ShortName { get; set; }
        public long? SortOrder { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
