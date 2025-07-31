using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrGratAmtPolicyDetails
    {
        public long DetPolId { get; set; }
        public long? PolId { get; set; }
        public long? SalHeadId { get; set; }
        public bool? CheckStatus { get; set; }
    }
}
