using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveMaster
    {
        public HrLeaveMaster()
        {
            HrLeaveDetails = new HashSet<HrLeaveDetails>();
        }

        public long LeaveId { get; set; }
        public string LappCode { get; set; }
        public long? StaffId { get; set; }
        public long? LeavetypeId { get; set; }
        public DateTime? AppLeaveFrom { get; set; }
        public DateTime? AppLeaveTo { get; set; }
        public string Type { get; set; }
        public long? Noofdays { get; set; }
        public DateTime? LeaveStart { get; set; }
        public DateTime? RejoiningDate { get; set; }
        public string Reason { get; set; }
        public string MedicalStatus { get; set; }
        public string ContactDetails { get; set; }
        public string AppStatus { get; set; }
        public long? AppStaffId { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public double? Allowed { get; set; }
        public DateTime? Lastrejoindate { get; set; }
        public int? EligibleDays { get; set; }
        public long? Calcdays { get; set; }
        public long? Payrollid { get; set; }
        public string FinalTimeSheetId { get; set; }
        public string TimeSheetNo { get; set; }
        public long? LeaveSalId { get; set; }
        public long? LeaveEncashId { get; set; }
        public string CreateThroughAtt { get; set; }
        public DateTime? LeaveCanDate { get; set; }
        public DateTime? LeaveCanAppDate { get; set; }
        public bool? LeaveCancel { get; set; }
        public bool? MangApp { get; set; }
        public bool? IncludeHolAl { get; set; }

        public virtual ICollection<HrLeaveDetails> HrLeaveDetails { get; set; }
    }
}
