using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAllotedProperties
    {
        public long Id { get; set; }
        public long? StaffId { get; set; }
        public long? AssetId { get; set; }
        public double? Cost { get; set; }
        public string Remarks { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; }
        public string BillPayedby { get; set; }
    }
}
