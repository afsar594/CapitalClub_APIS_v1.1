using EmpSelf.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
 public  class NewServiceRequest
    {
        public ServiceReqType serviceType { get; set; }
        public DateTime? Reqdate { get; set; }
        public int? ServiceReqEmp { get; set; }
        public string? ServiceReqReason { get; set; }
        public string? ServiceStaffReview { get; set; }


    }

    public class ServiceReqType
    {
        public int ServiceReqTypeId { get; set; }
        public string ServiceReqTypeName { get; set; }
        public int? Active { get; set; }
    }
}
