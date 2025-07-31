using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrExcelOtdetails
    {
        public long ExId { get; set; }
        public string StaffCode { get; set; }
        public string ExMonthName { get; set; }
        public long? ExYear { get; set; }
        public double? ElgDays { get; set; }
        public double? NorOt { get; set; }
        public double? HolOt { get; set; }
        public string Status { get; set; }
    }
}
