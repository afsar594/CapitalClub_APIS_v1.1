using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrPayrollMaster
    {
        public HrPayrollMaster()
        {
            HrPayrollDetails = new HashSet<HrPayrollDetails>();
        }

        public long PayrollId { get; set; }
        public string PayMonth { get; set; }
        public decimal? PayYear { get; set; }
        public DateTime? PayFrom { get; set; }
        public DateTime? PayTo { get; set; }
        public long? StaffId { get; set; }
        public double? NoOfDays { get; set; }
        public string LeaveRmk { get; set; }
        public bool? PostStatus { get; set; }
        public double? LoanAmount { get; set; }
        public double? Earnings { get; set; }
        public double? Deduction { get; set; }
        public string TansType { get; set; }
        public long? BankId { get; set; }
        public string BankAccNo { get; set; }
        public long? PersonId { get; set; }
        public string WpsIban { get; set; }
        public long? EmployerId { get; set; }
        public double? NorOt { get; set; }
        public double? NorOtamt { get; set; }
        public double? HolyOt { get; set; }
        public double? HolyOtamt { get; set; }
        public double? TotOt { get; set; }
        public double? TotOtamt { get; set; }
        public double? NorOtrate { get; set; }
        public double? HolyOtrate { get; set; }
        public double? FriOtrate { get; set; }
        public double? FriOtamt { get; set; }
        public double? FriOt { get; set; }
        public string Mode { get; set; }
        public long? LeaveSalId { get; set; }
        public double? BalAmount { get; set; }
        public double? BalDays { get; set; }
        public double? PaidAmount { get; set; }
        public bool? PayType { get; set; }
        public double? LeaveSalAmt { get; set; }
        public double? LeaveSalDys { get; set; }
        public double? GratuityAmt { get; set; }
        public double? GratuityDys { get; set; }
        public double? GratuityAmtThisMonth { get; set; }
        public double? GratuityDysThisMonth { get; set; }
        public string LiveInOut { get; set; }
        public string Jvid { get; set; }
        public DateTime? OtstDate { get; set; }
        public DateTime? OtendDate { get; set; }
        public double? C1000 { get; set; }
        public double? C500 { get; set; }
        public double? C200 { get; set; }
        public double? C100 { get; set; }
        public double? C50 { get; set; }
        public double? C20 { get; set; }
        public double? C10 { get; set; }
        public double? C5 { get; set; }
        public double? C1 { get; set; }
        public string Remarks { get; set; }
        public double? FixedDedAmt { get; set; }
        public double? NonElgDys { get; set; }
        public double? GrossPay { get; set; }
        public double? SalaryPaid { get; set; }
        public double? Balance { get; set; }
        public string Description { get; set; }
        public double? Credit { get; set; }
        public double? PrevCredit { get; set; }
        public double? AdvOther { get; set; }
        public double? Total { get; set; }
        public double? Bal { get; set; }
        public bool? HoldWps { get; set; }
        public double? Basic { get; set; }
        public double? Hra { get; set; }
        public double? Living { get; set; }
        public double? School { get; set; }
        public double? Tel { get; set; }
        public double? Ta { get; set; }
        public double? Others { get; set; }
        public double? PaidBasic { get; set; }
        public long? DaysInMonth { get; set; }
        public double? PaidLeave { get; set; }
        public double? UnpaidLeave { get; set; }
        public int? ShowZero { get; set; }
        public double? ManualLoanDedAmt { get; set; }

        public virtual HrStaffMaster Staff { get; set; }
        public virtual ICollection<HrPayrollDetails> HrPayrollDetails { get; set; }
    }
}
