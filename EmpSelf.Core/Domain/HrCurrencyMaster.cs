using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrCurrencyMaster
    {
        public decimal CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public decimal? CurrencyRate { get; set; }
        public string CurrencyRemarks { get; set; }
        public string CurType { get; set; }
        public long? UserId { get; set; }
        public bool? Status { get; set; }
    }
}
