using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
    public class LeaveBalanaceViewModel
    {

        public int StaffId { get; set; }           // Staff ID of the employee
        public string StaffCode { get; set; }           // Staff ID of the employee
        public string FullName { get; set; }        // Full name of the employee
        public string CompanyName { get; set; }     // Name of the company the employee belongs to
        public DateTime? JoiningDate { get; set; }   // Date when the employee joined the company
        public decimal? TotalLeaveBalance { get; set; }  // Total leave balance of the employee
        public string LeaveType { get; set; }        // Full name of the employee


    }
}
