using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAddress
    {
        public long AddressId { get; set; }
        public long? StaffId { get; set; }
        public int? AddressTypeId { get; set; }
        public string ContactPerson { get; set; }
        public string HouseName { get; set; }
        public string Street { get; set; }
        public long? StateId { get; set; }
        public long? CountryId { get; set; }
        public string Pobox { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public virtual HrAddressType AddressType { get; set; }
        public virtual HrStaffMaster Staff { get; set; }
    }
}
