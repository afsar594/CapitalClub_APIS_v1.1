using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeTable
    {
        public HrTimeTable()
        {
            HrShiftMemberAllocation = new HashSet<HrShiftMemberAllocation>();
            HrTimeTableDetails = new HashSet<HrTimeTableDetails>();
        }

        public long Ttid { get; set; }
        public string Description { get; set; }
        public bool? ActiveStatus { get; set; }
        public DateTime? NormalHr { get; set; }
        public string Tcode { get; set; }

        public virtual ICollection<HrShiftMemberAllocation> HrShiftMemberAllocation { get; set; }
        public virtual ICollection<HrTimeTableDetails> HrTimeTableDetails { get; set; }
    }
}
