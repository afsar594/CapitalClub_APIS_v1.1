using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTrainingDetails
    {
        public long Id { get; set; }
        public string StaffCode { get; set; }
        public string CourseName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Period { get; set; }
        public string Institution { get; set; }
        public decimal? CourseFee { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Remarks { get; set; }
    }
}
