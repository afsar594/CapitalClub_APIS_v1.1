using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrPendingPayroll
    {
        public long Ppid { get; set; }
        public long? StaffId { get; set; }
        public long? PayrollId { get; set; }
        public long? LeavSalId { get; set; }
        public string Paymonth { get; set; }
        public long? Payyear { get; set; }
        public double? NetAmount { get; set; }
        public string Status { get; set; }
    }
}
