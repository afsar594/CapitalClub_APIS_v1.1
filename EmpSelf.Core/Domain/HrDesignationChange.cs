using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDesignationChange
    {
        public int? Id { get; set; }
        public DateTime? DocDate { get; set; }
        public long? StaffId { get; set; }
        public string StaffName { get; set; }
        public long? CurrDesg { get; set; }
        public long? NewDesg { get; set; }
        public string Remarks { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
    }
}
