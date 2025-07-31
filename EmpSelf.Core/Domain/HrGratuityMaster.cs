using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrGratuityMaster
    {
        public long GrId { get; set; }
        public long? StaffId { get; set; }
        public DateTime? LastWorkingDay { get; set; }
        public string Remarks { get; set; }
        public double? GratDays { get; set; }
        public double? ServiceYrs { get; set; }
        public double? TotalDays { get; set; }
        public double? LeaveDays { get; set; }
        public double? DeductDays { get; set; }
        public double? EligibleDays { get; set; }
        public double? GratAmt { get; set; }
        public double? BasicSal { get; set; }
        public double? VarAdd { get; set; }
        public double? VarDed { get; set; }
        public double? TotAmt { get; set; }
        public string DedRemarks { get; set; }
        public string AddRemarks { get; set; }
        public string EmpStatus { get; set; }
        public long? LeaveSalId { get; set; }
        public double? Aldays { get; set; }
        public DateTime? AlsettDate { get; set; }
        public double? Alamt { get; set; }
        public double? Cldays { get; set; }
        public DateTime? ClsettDate { get; set; }
        public double? Clamt { get; set; }
        public long? PayrollId { get; set; }
        public double? TerminationAmt { get; set; }
        public double? TotServYrs { get; set; }
        public bool? IncludePayroll { get; set; }
        public bool? ExcludeLeave { get; set; }
        public string Pvno { get; set; }
        public double? GrtAmtLessFive { get; set; }
        public double? GrtAmtGrterFive { get; set; }
        public double? GrtDysGrtFive { get; set; }
        public double? GrtYrsGrtFive { get; set; }
        public DateTime? GrtCalcChangeDate { get; set; }
        public bool? ExcludeGratuity { get; set; }
        public bool? ExcludeLeaveSalary { get; set; }
        public bool? ExcludeSalary { get; set; }
    }
}
