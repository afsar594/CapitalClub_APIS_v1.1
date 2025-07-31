using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrContractType
    {
        public long ContTypeId { get; set; }
        public string ContType { get; set; }
        public string Remarks { get; set; }
    }
}
