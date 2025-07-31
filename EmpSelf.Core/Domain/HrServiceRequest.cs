using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrServiceRequest
    {
        public int ServiceReqId { get; set; }
        public int? ServiceReqType { get; set; }
        public DateTime? ServiceReqDate { get; set; }
        public long? ServiceReqEmp { get; set; }
        public int? ServiceReqStatus { get; set; }
        public DateTime? ServiceReqApproveDate { get; set; }
        public string? ServiceReqRemarks { get; set; }
        public int? ServiceReqApprovedBy { get; set; }
        public string? ServiceReqReason { get; set; }
        public byte[] ServiceReqAprovImg { get; set; }

        public string? ServiceStaffReview { get; set; }
        public string? CompanyName { get; set; }

        public string? hruser { get; set; }




        public virtual HrServiceRequestType ServiceReqTypeNavigation { get; set; }

    }
}
