using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetMulStaffDetails
    {
        public long TsId { get; set; }
        public long? Sno { get; set; }
        public long? Staffid { get; set; }
        public double? NormHr { get; set; }
        public double? NormOt { get; set; }
        public double? HolOt { get; set; }
        public double? FriOt { get; set; }
        public string RemarksDet { get; set; }
        public long? SiteIdorg { get; set; }
        public long? SiteIdmod { get; set; }
        public bool? IsEdit { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? BrkIn { get; set; }
        public DateTime? BrkOut { get; set; }
        public DateTime? TotHr { get; set; }
        public double? InTimeFloat { get; set; }
        public double? BrOutTimeFloat { get; set; }
        public double? BrInTimeFloat { get; set; }
        public double? OutTimeFloat { get; set; }
        public double? BrTotTimeFloat { get; set; }
        public double? TotTimeFloat { get; set; }
        public long? PayrollId { get; set; }
        public long? LocationId { get; set; }
        public long? DesigId { get; set; }

        public virtual HrTimeSheetMulStaff Ts { get; set; }
    }
}
