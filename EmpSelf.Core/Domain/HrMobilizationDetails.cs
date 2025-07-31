using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrMobilizationDetails
    {
        public long MobDetId { get; set; }
        public long? MobId { get; set; }
        public long? Sno { get; set; }
        public long? Staffid { get; set; }
        public long? DesigId { get; set; }
        public long? SiteId { get; set; }
        public long? LocationId { get; set; }
        public string RemarksDet { get; set; }
        public bool? IsEdit { get; set; }
        public DateTime? JoinDate { get; set; }
    }
}
