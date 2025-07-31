using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeSettings
    {
        public long TimeSettingId { get; set; }
        public long? TimePolicyId { get; set; }
        public string Policyname { get; set; }
        public string Remarks { get; set; }
        public bool? LastMinusIn { get; set; }
        public bool? SumAll { get; set; }
        public bool? SlogTime { get; set; }
        public double? SlogBefShift { get; set; }
        public double? SlogAftShift { get; set; }
        public bool? GracetimeYn { get; set; }
        public double? Gracetime { get; set; }
        public bool? HalfdayYn { get; set; }
        public bool? LateTimes { get; set; }
        public int? LateTimeNo { get; set; }
        public string PeriodType { get; set; }
        public int? DedDays { get; set; }
        public bool? Marklate { get; set; }
        public bool? HalfDayTime { get; set; }
        public double? HalfDayTimeHr { get; set; }
        public double? HalfDayTimeMnt { get; set; }
        public bool? AbsentMark { get; set; }
        public double? AbsentHrs { get; set; }
        public double? AbsentMnts { get; set; }
        public bool? HalfdayGreaterYn { get; set; }
        public DateTime? HalfdayGreater { get; set; }
        public bool? HalfDayLessYn { get; set; }
        public DateTime? HalfDayLess { get; set; }
        public long? Braktime { get; set; }
        public bool? ExcludeHolFriOt { get; set; }
        public bool? AddHolWrkComOff { get; set; }
        public bool? ConsiderSinglePunchPresent { get; set; }
        public double? GracetimeGe { get; set; }
        public int? LateTimeNoGe { get; set; }
        public string PeriodTypeGe { get; set; }
        public int? DedDaysGe { get; set; }
        public long? BreaktimeGe { get; set; }
        public bool? GracetimeYnge { get; set; }
        public bool? HalfdayYnge { get; set; }
        public bool? LateTimesGe { get; set; }
        public bool? MarklateGe { get; set; }
    }
}
