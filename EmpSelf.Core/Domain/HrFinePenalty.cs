using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrFinePenalty
    {
        public long Id { get; set; }
        public long? StaffCode { get; set; }
        public string Rwdtype { get; set; }
        public DateTime? Date { get; set; }
        public string Nature { get; set; }
        public string Actiontaken { get; set; }
        public string Remarks { get; set; }
    }
}
