using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrVisaCompany
    {
        public HrVisaCompany()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long VisaCompanyId { get; set; }
        public string VisaCompany { get; set; }
        public long? VisaEmployerId { get; set; }
        public long? VisaEmployerBankId { get; set; }
        public bool? IsAnyPrefix { get; set; }
        public string Prefix { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
