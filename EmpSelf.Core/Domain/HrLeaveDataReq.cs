using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveDataReq
    {
        public int LeavDataId { get; set; }
        public long? LeaveEmpid { get; set; }
        public int? LeaveDataType { get; set; }
        public DateTime? LeaveDataFrom { get; set; }
        public DateTime? LeaveDataTo { get; set; }
        public int? LeaveDays { get; set; }
        public string LeaveDataReason { get; set; }
        public DateTime? ReqDate { get; set; }
        public DateTime? ApproveDate { get; set; }
        public long? ApprovedBy { get; set; }
        public DateTime? RejectedDate { get; set; }
        public long? RejectedBy { get; set; }
        public string? Remarks { get; set; }
        public int? Status { get; set; }

        public byte[] LeaveReqImage { get; set; }

        public virtual HrLeaveType LeaveDataTypeNavigation { get; set; }
        public virtual HrUsers LeaveEmp { get; set; }
    }
}
