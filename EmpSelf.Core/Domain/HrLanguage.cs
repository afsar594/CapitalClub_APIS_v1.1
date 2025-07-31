using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLanguage
    {
        public HrLanguage()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long LanguageId { get; set; }
        public string Language { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
