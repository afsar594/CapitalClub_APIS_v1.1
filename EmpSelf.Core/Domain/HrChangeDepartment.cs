using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrChangeDepartment
    {
        public int? Id { get; set; }
        public DateTime? Date { get; set; }
        public string Remarks { get; set; }
    }
}
