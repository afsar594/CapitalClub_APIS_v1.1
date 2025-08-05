using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HRLeaveApprovalStaffdetails
    {
        public int Id { get; set; }
        public long? LeaveID { get; set; }
        public long? PermissionStaffID { get; set; }
        public int? ApproveStatus { get; set; }
        public string Remarks { get; set; }
    }
}
