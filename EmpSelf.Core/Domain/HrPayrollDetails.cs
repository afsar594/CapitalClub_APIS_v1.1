using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrPayrollDetails
    {
        public long PayrollDetailsId { get; set; }
        public long? PayrollId { get; set; }
        public long? Staffid { get; set; }
        public long? ShId { get; set; }
        public double? EligibleAmount { get; set; }
        public double? ActualAmt { get; set; }
        public string Remarks { get; set; }

        public virtual HrPayrollMaster Payroll { get; set; }
        public virtual HrSalaryHead Sh { get; set; }
    }
}
