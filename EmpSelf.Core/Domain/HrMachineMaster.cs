using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrMachineMaster
    {
        public HrMachineMaster()
        {
            HrAttLog = new HashSet<HrAttLog>();
        }

        public int MachineCode { get; set; }
        public int MachineNo { get; set; }
        public string MachineName { get; set; }
        public string IpAddress { get; set; }
        public string ComPort { get; set; }
        public int? BudRate { get; set; }
        public string ConnectionType { get; set; }
        public byte? MachineMode { get; set; }
        public string PunchMode { get; set; }
        public string Discription { get; set; }
        public DateTime? HrlastUpLoadDate { get; set; }
        public DateTime? ExcelLastUpLoadDate { get; set; }
        public long? LocationId { get; set; }
        public bool? IsMasterMachine { get; set; }
        public string CommunicationKey { get; set; }

        public virtual ICollection<HrAttLog> HrAttLog { get; set; }
    }
}
