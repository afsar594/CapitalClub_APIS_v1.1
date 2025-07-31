using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAirTicketDetails
    {
        public long? Atdid { get; set; }
        public long? Atid { get; set; }
        public long? Sno { get; set; }
        public long? Staffid { get; set; }
        public long? FamilyId { get; set; }
        public bool? TicketAvailable { get; set; }
        public string Type { get; set; }
    }
}
