using EmpSelf.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
 public  class ServiceRequestViewModel
    {
      
        public DateTime? ServiceReqDate { get; set; }
        public int ServiceReqId { get; set; }
        public int? ServiceReqStatus { get; set; }
        public int? ServiceReqType { get; set; }
        public string ServiceReqReason { get; set; }
        public string CompanyName { get; set; }
        public string? ServiceStaffReview { get; set; }

        public HrServiceRequestType ServiceReqTypeNavigation { get; set; }
    }


}
