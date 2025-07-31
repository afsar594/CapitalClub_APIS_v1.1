using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveEncashment
    {
        public long? Lecid { get; set; }
        public long? Lsid { get; set; }
        public long? Staffid { get; set; }
        public DateTime? LastRejionDate { get; set; }
        public double? NoAlavailable { get; set; }
        public double? EncashDys { get; set; }
        public double? BalanceDys { get; set; }
        public double? EncashAmount { get; set; }
        public string Remarks { get; set; }
        public DateTime? EncahmentDate { get; set; }
        public DateTime? LeaveStDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        public bool? AlCl { get; set; }
        public double? AirticketAmt { get; set; }
    }
}
