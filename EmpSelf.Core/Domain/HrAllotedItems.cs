using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAllotedItems
    {
        public long AllotedItemId { get; set; }
        public long? StaffCode { get; set; }
        public string AllotedItem { get; set; }
        public DateTime? AllotDate { get; set; }
    }
}
