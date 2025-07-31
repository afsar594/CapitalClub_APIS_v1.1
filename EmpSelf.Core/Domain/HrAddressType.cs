using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAddressType
    {
        public HrAddressType()
        {
            HrAddress = new HashSet<HrAddress>();
        }

        public string AddressType { get; set; }
        public int AddressTypeId { get; set; }

        public virtual ICollection<HrAddress> HrAddress { get; set; }
    }
}
