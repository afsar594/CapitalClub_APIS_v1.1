using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrActiveStatus
    {
        public long ActiveStatusId { get; set; }
        public string ActiveStatus { get; set; }
        public string ShortName { get; set; }
    }
}
