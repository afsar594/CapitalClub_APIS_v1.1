using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetBrkUp
    {
        public long? BrkUpId { get; set; }
        public long? BrkUpMastId { get; set; }
        public long? BrkUpDtlId { get; set; }
        public string BrkUpDay { get; set; }
        public DateTime? BrkUpDate { get; set; }
        public decimal? BrkUpNormal { get; set; }
        public decimal? BrkUpOt { get; set; }
        public long? BrkUpProjId { get; set; }
        public string BrkUpRemarks { get; set; }
        public double? NorAmt { get; set; }
        public double? Otamt { get; set; }
    }
}
