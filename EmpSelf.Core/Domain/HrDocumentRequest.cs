using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDocumentRequest
    {
        public int ReqId { get; set; }
        public long? StaffId { get; set; }
        public long? AppByStaffId { get; set; }
        public string InOut { get; set; }
        public string AppStatus { get; set; }
        public long DocTypeId { get; set; }
        public string Purpose { get; set; }
        public string Remarks { get; set; }
        public DateTime? AppDate { get; set; }
        public DateTime? ApproveDate { get; set; }
        public bool? Approved { get; set; }
    }
}
