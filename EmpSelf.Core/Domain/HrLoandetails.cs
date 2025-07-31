using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLoandetails
    {
        public int Ldid { get; set; }
        public decimal? LoanId { get; set; }
        public long? StaffId { get; set; }
        public decimal? PayrollId { get; set; }
        public DateTime? DedDate { get; set; }
        public double? DedAmount { get; set; }
        public string DedMonth { get; set; }
        public string DedYear { get; set; }
        public string DedType { get; set; }

        public virtual HrLoanentry Loan { get; set; }
    }
}
