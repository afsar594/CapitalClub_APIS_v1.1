using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrOvertimeSettings
    {
        public long OvtmId { get; set; }
        public long? OvtPlocyId { get; set; }
        public string OvtPolicyName { get; set; }
        public bool? OutMinShiftEndYn { get; set; }
        public bool? TotalDurMinSftYn { get; set; }
        public bool? EarlyLatePlusYn { get; set; }
        public bool? SalarySlipOtyn { get; set; }
        public bool? ExtraHrsSlipYn { get; set; }
        public double? OtlimitMnt { get; set; }
        public double? OtlimitHrs { get; set; }
        public int? TimeBefOtstart { get; set; }
        public int? MaxOtHrsMin { get; set; }
        public double? MaxOtHrsHrs { get; set; }
        public double? LateComOtnegoMnts { get; set; }
    }
}
