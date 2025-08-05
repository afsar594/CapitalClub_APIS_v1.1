using EmpSelf.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
   public class LeaveDataViewModel
    {
        public int LeavDataId { get; set; }
        public long? LeaveEmpid { get; set; }
        public int? LeaveDataType { get; set; }
        public string LeaveDataFrom { get; set; }
        public string LeaveDataTo { get; set; }
        public int? LeaveDays { get; set; }
        public string LeaveDataReason { get; set; }
        public DateTime? ReqDate { get; set; }
        public int? Status { get; set; }
        public string? LeaveEmpName { get; set; }
        public string CompanyName { get; set; }
        public virtual HrLeaveType LeaveDataTypeNavigation { get; set; }
        public virtual HrUsers LeaveEmp { get; set; }
        public int? Remaining { get; set; }
    }
}
