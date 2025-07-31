using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSheetKz
    {
        public HrTimeSheetKz()
        {
            HrTimeSheetDetailsKz = new HashSet<HrTimeSheetDetailsKz>();
        }

        public long Tsid { get; set; }
        public DateTime? Tsdate { get; set; }
        public long? StaffId { get; set; }
        public string Remarks { get; set; }
        public bool? SubmitTs { get; set; }

        public virtual ICollection<HrTimeSheetDetailsKz> HrTimeSheetDetailsKz { get; set; }
    }
}
