using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrProcessedAttendance
    {
        public long? ApId { get; set; }
        public DateTime? PunchDate { get; set; }
        public long? EnrollNo { get; set; }
        public long? StaffId { get; set; }
        public int? MachineIdIn { get; set; }
        public int? MachineIdOut { get; set; }
        public int? VerifyMode { get; set; }
        public long? CreateUser { get; set; }
        public long? LastUpdateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public long? AttLogIdIn { get; set; }
        public long? AttLogIdOut { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public DateTime? InTimeManual { get; set; }
        public DateTime? OutTimeManual { get; set; }
        public double? InTimeFloat { get; set; }
        public double? OutTimeFloat { get; set; }
        public DateTime? NormalHr { get; set; }
        public double? NormalHrFloat { get; set; }
        public DateTime? Othr { get; set; }
        public double? OthrFloat { get; set; }
        public DateTime? BreakHr { get; set; }
        public double? BreakHrFloat { get; set; }
        public long? ShiftId { get; set; }
        public DateTime? LateComing { get; set; }
        public DateTime? EarlyGoing { get; set; }
        public string PostStatus { get; set; }
        public long? LeaveStatusId { get; set; }
        public string Remarks { get; set; }
        public double? TotTimeFloat { get; set; }
        public DateTime? TotTime { get; set; }
        public bool? MissPunch { get; set; }
        public bool? NoPunch { get; set; }
        public double? LateComingFloat { get; set; }
        public double? EarlyGoingFloat { get; set; }
        public DateTime? DutyIn { get; set; }
        public DateTime? DutyOut { get; set; }
        public bool? EditAtte { get; set; }
        public DateTime? LunchBreakOut { get; set; }
        public double? LunchBreakOutFloat { get; set; }
        public DateTime? LunchBreakOutActual { get; set; }
        public DateTime? LunchBreakIn { get; set; }
        public double? LunchBreakInFloat { get; set; }
        public DateTime? LunchBreakInActual { get; set; }
        public DateTime? LunchBreakTotal { get; set; }
        public double? LunchBreakTotalFloat { get; set; }
        public DateTime? LongBreakOut { get; set; }
        public double? LongBreakOutFloat { get; set; }
        public DateTime? LongBreakOutActual { get; set; }
        public DateTime? LongBreakIn { get; set; }
        public double? LongBreakInFloat { get; set; }
        public DateTime? LongBreakInActual { get; set; }
        public DateTime? LongBreakTotal { get; set; }
        public double? LongBreakTotalFloat { get; set; }
        public DateTime? DinnerBreakOut { get; set; }
        public double? DinnerBreakOutFloat { get; set; }
        public DateTime? DinnerBreakOutActual { get; set; }
        public DateTime? DinnerBreakIn { get; set; }
        public double? DinnerBreakInFloat { get; set; }
        public DateTime? DinnerBreakInActual { get; set; }
        public DateTime? DinnerBreakTotal { get; set; }
        public double? DinnerBreakTotalFloat { get; set; }
        public DateTime? MorningShiftTotal { get; set; }
        public double? MorningShiftTotalFloat { get; set; }
        public DateTime? AfterNoonShiftTotal { get; set; }
        public double? AfterNoonShiftTotalFloat { get; set; }
        public DateTime? EveningShiftTotal { get; set; }
        public double? EveningShiftTotalFloat { get; set; }
        public DateTime? NightShiftTotal { get; set; }
        public double? NightShiftTotalFloat { get; set; }
        public bool? ProcessStatus { get; set; }
        public DateTime? SlabOthr { get; set; }
        public double? SlabOthrFloat { get; set; }
        public DateTime? SplOthr { get; set; }
        public double? SplOthrFloat { get; set; }
        public bool? FreezProcess { get; set; }
    }
}
