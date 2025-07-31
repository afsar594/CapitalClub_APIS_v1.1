using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrUsers
    {
        public HrUsers()
        {
            HrAttendaceSheet = new HashSet<HrAttendaceSheet>();
            HrLeaveDataReq = new HashSet<HrLeaveDataReq>();
            HrUserPermission = new HashSet<HrUserPermission>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Passwd { get; set; }
        public string Mode { get; set; }
        public int CompanyId { get; set; }
        public int? LoginCount { get; set; }
        public string WorkPosition { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public bool? CurrentlyLogin { get; set; }
        public long? WorkgroupId { get; set; }
        public string StaffName { get; set; }
        public string PassportNo { get; set; }
        public string Designation { get; set; }

        public virtual HrWorkPosition WorkPositionNavigation { get; set; }
        public virtual ICollection<HrAttendaceSheet> HrAttendaceSheet { get; set; }
        public virtual ICollection<HrLeaveDataReq> HrLeaveDataReq { get; set; }
        public virtual ICollection<HrUserPermission> HrUserPermission { get; set; }

    }
}
