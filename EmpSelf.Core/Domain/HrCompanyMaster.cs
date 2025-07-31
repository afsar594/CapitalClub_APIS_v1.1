using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrCompanyMaster
    {
        public HrCompanyMaster()
        {
            HrStaffMaster = new HashSet<HrStaffMaster>();
        }

        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Licno { get; set; }
        public string Addr { get; set; }
        public string Post { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public long? WpsemployerId { get; set; }
        public long? WpsemployerBankId { get; set; }
        public bool? IsDefaultCompany { get; set; }
        public byte[] CompanyLogo { get; set; }
        public string PayerEid { get; set; }
        public string PayerQid { get; set; }
        public bool? Sifdefault { get; set; }
        public string Trnno { get; set; }

        public virtual ICollection<HrStaffMaster> HrStaffMaster { get; set; }
    }
}
