using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrChangeDesignationDet
    {
        public int? Id { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public long? CurrDesg { get; set; }
        public long? NewDesg { get; set; }
        public string Remarks { get; set; }
    }
}
