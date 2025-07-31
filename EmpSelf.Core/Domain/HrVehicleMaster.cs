using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrVehicleMaster
    {
        public long Id { get; set; }
        public string VehicleTye { get; set; }
        public string VehicleNo { get; set; }
        public string EngineNo { get; set; }
        public string ChasisNo { get; set; }
        public bool? Sold { get; set; }
        public long? StaffId { get; set; }
        public long? LocationId { get; set; }
        public long? CompanyId { get; set; }
    }
}
