using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrBankMaster
    {
        public long BankId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public long? WpsagentId { get; set; }
        public string ShortName { get; set; }
        public string Iban { get; set; }
    }
}
