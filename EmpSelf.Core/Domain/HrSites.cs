using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrSites
    {
        public long SiteId { get; set; }
        public string SiteName { get; set; }
        public string ShortName { get; set; }
        public long? ErpSiteId { get; set; }
        public DateTime? StDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
