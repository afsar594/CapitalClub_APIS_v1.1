using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrFamilyDetails
    {
        public int Id { get; set; }
        public long? StaffId { get; set; }
        public string Name { get; set; }
        public int? RelId { get; set; }
        public bool? MedicalIns { get; set; }
        public bool? Ticket { get; set; }
        public decimal? Amount { get; set; }
    }
}
