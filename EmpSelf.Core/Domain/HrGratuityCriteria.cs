using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrGratuityCriteria
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long? GratFrmDays { get; set; }
        public long? GratToDays { get; set; }
        public double? GratDays { get; set; }
        public string Remarks { get; set; }
        public string ServiceType { get; set; }
        public string Remarks2 { get; set; }
    }
}
