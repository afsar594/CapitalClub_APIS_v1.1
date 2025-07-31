using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDocumentInOutDetails
    {
        public long Id { get; set; }
        public DateTime? OutDate { get; set; }
        public DateTime? InDate { get; set; }
        public long? DocTypeId { get; set; }
        public string Status { get; set; }
        public long? StaffId { get; set; }
        public long? IssueStaffid { get; set; }
        public long? AuthorisedStaffId { get; set; }
        public string Purpose { get; set; }
        public string Remarks { get; set; }
        public string Lcno { get; set; }
        public DateTime? Lcdate { get; set; }
        public long? LeaveId { get; set; }
        public double? DocResubDys { get; set; }
    }
}
