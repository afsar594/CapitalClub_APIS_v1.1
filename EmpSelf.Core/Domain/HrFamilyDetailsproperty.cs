using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrFamilyDetailsproperty
    {
        public long? Id { get; set; }
        public long? StaffId { get; set; }
        public string Fname { get; set; }
        public string Ftype { get; set; }
        public int? RelId { get; set; }
        public string Visano { get; set; }
        public string Passportno { get; set; }
        public DateTime? Visaexpdate { get; set; }
        public DateTime? Passportexpdate { get; set; }
        public bool? Medicalinsurance { get; set; }
        public bool? Airticket { get; set; }
        public string Remarks { get; set; }
        public DateTime? PassporIssuDate { get; set; }
        public DateTime? VisaissuDate { get; set; }
        public DateTime? EmirateIssuDate { get; set; }
        public DateTime? EmirateExpDate { get; set; }
    }
}
