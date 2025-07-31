using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrServiceRequestType
    {
        public HrServiceRequestType()
        {
           // HrServiceRequest = new HashSet<HrServiceRequest>();
        }

        public int ServiceReqTypeId { get; set; }
        public string ServiceReqTypeName { get; set; }
        public int? Active { get; set; }

        //public virtual ICollection<HrServiceRequest> HrServiceRequest { get; set; }
    }
}
