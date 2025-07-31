using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrChangeDepartmentDet
    {
        public int? Id { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public long? CurrDept { get; set; }
        public long? NewDept { get; set; }
        public string Remarks { get; set; }
    }
}
