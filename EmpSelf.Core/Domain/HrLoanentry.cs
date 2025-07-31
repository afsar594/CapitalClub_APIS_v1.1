using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLoanentry
    {
        public HrLoanentry()
        {
            HrLoandetails = new HashSet<HrLoandetails>();
        }

        public decimal LoanId { get; set; }
        public decimal? LoanHeadId { get; set; }
        public long? Staffid { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? DedFromDate { get; set; }
        public double? LoanAmount { get; set; }
        public double? NoOfInst { get; set; }
        public double? InstAmount { get; set; }
        public bool? Hold { get; set; }
        public double? AmtPaid { get; set; }
        public double? Balance { get; set; }
        public string RefNo { get; set; }
        public string Remarks { get; set; }
        public double? CurMnthPayrollDedAmt { get; set; }
        public string Jvid { get; set; }

        public virtual ICollection<HrLoandetails> HrLoandetails { get; set; }
    }
}
