using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAttLog
    {
        public long AttLogId { get; set; }
        public long? EnrollNo { get; set; }
        public int? VerifyMode { get; set; }
        public int? InOutMode { get; set; }
        public DateTime? TimeStr { get; set; }
        public int? MachineId { get; set; }
        public int? WorkCode { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? LastUpdateUser { get; set; }
        public DateTime? BeforeUpdateTimeStr { get; set; }
        public bool? IsEdit { get; set; }
        public DateTime? DownloadDate { get; set; }
        public DateTime? TotTime { get; set; }
        public string ExLess { get; set; }

        public virtual HrMachineMaster Machine { get; set; }
    }
}
