using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrSubDepartment
    {
        public long? SubDepId { get; set; }
        public string SubDepName { get; set; }
        public string SubDepCode { get; set; }
        public long? SortOrder { get; set; }
        public long? DepId { get; set; }
    }
}
