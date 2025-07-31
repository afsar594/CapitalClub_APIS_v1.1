using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveSalary
    {
        public long LeaveSalId { get; set; }
        public long? Staffid { get; set; }
        public DateTime? LastSettDate { get; set; }
        public DateTime? SettDate { get; set; }
        public double? LeaveDays { get; set; }
        public double? TotalDays { get; set; }
        public double? TotalDaysWorked { get; set; }
        public double? EligibleDays { get; set; }
        public double? LeaveSalary { get; set; }
        public double? VarAdd { get; set; }
        public double? VarDed { get; set; }
        public double? TotalLeaveSalary { get; set; }
        public string Remarks { get; set; }
        public bool? Approve { get; set; }
        public double? TakenDays { get; set; }
        public double? TotEarnings { get; set; }
        public long? PayrollId { get; set; }
        public DateTime? LeaveSalaryDate { get; set; }
        public DateTime? AlstartDate { get; set; }
        public DateTime? AlendDate { get; set; }
        public double? LoanAmt { get; set; }
        public double? PendingPayollAmt { get; set; }
        public double? AirTicketAmt { get; set; }
        public double? GratuityAmt { get; set; }
        public double? PayrollAmt { get; set; }
        public double? NetAmt { get; set; }
        public double? AlopnBal { get; set; }
        public string SettlementType { get; set; }
        public string RmkVarAdd { get; set; }
        public string RmkVarDed { get; set; }
        public double? CurLeaveDys { get; set; }
        public string CalculateBasedOn { get; set; }
        public bool? CreateLeave { get; set; }
        public bool? CreatePayroll { get; set; }
        public bool? AddLspayroll { get; set; }
        public double? NoofTicket { get; set; }
        public double? PrvMthSalary { get; set; }
        public string PrvPayrollMonth { get; set; }
        public DateTime? RejoinDate { get; set; }
        public bool? RejoinStatus { get; set; }
        public bool? AlongWithPayroll { get; set; }
    }
}
