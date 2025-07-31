using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrCompanyCalender
    {
        public decimal Id { get; set; }
        public DateTime? Mdate { get; set; }
        public string Mday { get; set; }
        public string Mdesc { get; set; }
        public double? Mtfrom { get; set; }
        public double? Mtto { get; set; }
        public double? Hrs { get; set; }
        public long? StaffTypeId { get; set; }
        public long? MonthId { get; set; }
        public long? YearId { get; set; }
        public long? DayId { get; set; }
    }
}
