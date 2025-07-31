using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrIncrementDetail
    {
        public long? Id { get; set; }
        public long? Sno { get; set; }
        public long? Salheadcode { get; set; }
        public double? CurrSalary { get; set; }
        public double? Incramount { get; set; }
        public double? Newsalamount { get; set; }
        public string Remarks { get; set; }
    }
}
