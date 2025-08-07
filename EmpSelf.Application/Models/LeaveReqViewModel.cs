using EmpSelf.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
  public  class LeaveReqViewModel
    {
        public int LeavDataId { get; set; }
        public int? LeaveEmpid { get; set; }
        public int? LeaveDataType { get; set; }

        public string LeaveDataFrom { get; set; }

        public string LeaveDataTo { get; set; }
        public int? LeaveDays { get; set; }
        public string LeaveDataReason { get; set; }
        public DateTime? ReqDate { get; set; }

        public string? LeaveEmpName { get; set; }
        public DateTime? ApproveDate { get; set; }

        public long? ApprovedBy { get; set; }
        public DateTime? RejectedDate { get; set; }
        public long? RejectedBy { get; set; }
        public string? Remarks { get; set; }
        public int? Status { get; set; }

        public byte[] LeaveReqImage { get; set; }
        public  HrLeaveType LeaveDataTypeNavigation { get; set; }

        public string CompanyName { get; set; }
        public int? Remaining { get; set; }
    }
}
