using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrSalaryPackage
    {
        public long Spid { get; set; }
        public long? StaffId { get; set; }
        public long? Shid { get; set; }
        public double? Amount { get; set; }
        public string Nature { get; set; }
        public string Remarks { get; set; }

        public virtual HrSalaryHead Sh { get; set; }
        public virtual HrStaffMaster Staff { get; set; }
    }
}
