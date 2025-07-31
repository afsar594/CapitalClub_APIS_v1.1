using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrGratAmtPolicyMaster
    {
        public long? PolId { get; set; }
        public string PolicyName { get; set; }
        public bool? PolcyType { get; set; }
        public string Remarks { get; set; }
    }
}
