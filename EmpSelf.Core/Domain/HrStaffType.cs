using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrStaffType
    {
        public long StaffTypeId { get; set; }
        public string StaffType { get; set; }
        public double? NorHrRate { get; set; }
        public double? NorOtrate { get; set; }
        public double? FridayRate { get; set; }
        public double? HolidayRate { get; set; }
        public string DebAccNo { get; set; }
    }
}
