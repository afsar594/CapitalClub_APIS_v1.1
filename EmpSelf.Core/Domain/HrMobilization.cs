using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrMobilization
    {
        public long MobId { get; set; }
        public DateTime? MobDate { get; set; }
        public string Remarks { get; set; }
        public bool? SubmitMob { get; set; }
    }
}
