using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
  public  class LeaveTypeViewModel
    {

        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public string LeaveCode { get; set; }
        public bool? IsDeduct { get; set; }
        public double? DayType { get; set; }
        public bool? LcodeEditable { get; set; }
        public bool? ActiveStatus { get; set; }
    }
}
