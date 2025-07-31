using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveBalance
    {
        public int LeaveBalId { get; set; }
        public int? LeaveBalCode { get; set; }
        public string LeaveBalType { get; set; }
        public int LeaveBalUserid { get; set; }
        public decimal? LeaveBalNo { get; set; }
        public bool? LeaveBalStatus { get; set; }


    }
}
