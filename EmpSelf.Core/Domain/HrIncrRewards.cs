using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrIncrRewards
    {
        public long Id { get; set; }
        public string StaffCode { get; set; }
        public string Rwdtype { get; set; }
        public DateTime? Date { get; set; }
        public string Nature { get; set; }
        public string Achievement { get; set; }
        public string Remarks { get; set; }
    }
}
