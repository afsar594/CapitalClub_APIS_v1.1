using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrCompanyBankDetails
    {
        public long Cbid { get; set; }
        public long? CompId { get; set; }
        public long? BankId { get; set; }
        public bool? IsEdit { get; set; }
    }
}
