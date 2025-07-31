using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrPayrollColumns
    {
        public string ColumnName { get; set; }
        public long? Visible { get; set; }
        public long? SortOrder { get; set; }
    }
}
