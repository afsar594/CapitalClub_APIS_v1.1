using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrOtherExpProperties
    {
        public long Id { get; set; }
        public long? StaffId { get; set; }
        public string RewType { get; set; }
        public double? Amont { get; set; }
        public string BillNo { get; set; }
        public string Remarks { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public long? Oeid { get; set; }
    }
}
