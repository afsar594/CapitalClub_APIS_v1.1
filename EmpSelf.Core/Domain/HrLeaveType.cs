using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveType
    {
        public HrLeaveType()
        {
            //HrLeaveDataReq = new HashSet<HrLeaveDataReq>();
        }

        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public string LeaveCode { get; set; }
        public bool? IsDeduct { get; set; }
        public double? DayType { get; set; }
        public bool? LcodeEditable { get; set; }
        public bool? ActiveStatus { get; set; }


        public long? LeaveID { get; set; }
        // public virtual ICollection<HrLeaveDataReq> HrLeaveDataReq { get; set; }
    }
}
