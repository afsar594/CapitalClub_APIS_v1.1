using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLocationComp
    {
        public long LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocaAdd { get; set; }
        public bool? Deleted { get; set; }
    }
}
