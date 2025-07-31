using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetDetailsKz
    {
        public long Sno { get; set; }
        public long? Tsid { get; set; }
        public long? ProjId { get; set; }
        public DateTime? Intime { get; set; }
        public DateTime? Outtime { get; set; }
        public DateTime? TotHr { get; set; }
        public double? IntimeFloat { get; set; }
        public double? OutTimeFloat { get; set; }
        public double? TotHrFloat { get; set; }
        public string Remarks { get; set; }

        public virtual HrTimeSheetKz Ts { get; set; }
    }
}
