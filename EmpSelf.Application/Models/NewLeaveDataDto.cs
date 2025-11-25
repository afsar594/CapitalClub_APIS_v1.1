using EmpSelf.Core.Domain;
using System;

namespace EmpSelf.Application.Models
{
 public   class NewLeaveDataDto
    {
        public string imageFile { get; set; }
        public int TotalDays { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public HrLeaveType LeaveType { get; set; }
        public int EmployeeID { get; set; }
     

    }
    
}

