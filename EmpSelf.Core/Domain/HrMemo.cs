using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrMemo
    {
        public int Id { get; set; }
        public string MemoId { get; set; }
        public DateTime? MemoDate { get; set; }
        public string Reply { get; set; }
        public int? EmpId { get; set; }
        public string Remarks { get; set; }
    }
}
