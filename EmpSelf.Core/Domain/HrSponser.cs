using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrSponser
    {
        public long SponserId { get; set; }
        public string Sponser { get; set; }
        public string Remarks { get; set; }
    }
}
