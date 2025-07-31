using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrTimeTableDetails
    {
        public long TtdetailsId { get; set; }
        public long? Ttid { get; set; }
        public DateTime? InTimeEarlyHr { get; set; }
        public DateTime? InTimeEarlyTrim1 { get; set; }
        public DateTime? InTimeEarlyTrim2 { get; set; }
        public DateTime? InTimeEarlyTrim3 { get; set; }
        public DateTime? InTimeHr { get; set; }
        public DateTime? IntimeLateTrim1 { get; set; }
        public DateTime? InTimeLateTrim2 { get; set; }
        public DateTime? InTimeLateTrim3 { get; set; }
        public DateTime? InTimeLateHr { get; set; }
        public DateTime? OutTimeEarlyHr { get; set; }
        public DateTime? OutTimeEarlyTrim1 { get; set; }
        public DateTime? OutTimeEarlyTrim2 { get; set; }
        public DateTime? OutTimeEarlyTrim3 { get; set; }
        public DateTime? OutTimeHr { get; set; }
        public DateTime? OutTimeLateTrim1 { get; set; }
        public DateTime? OutTimeLateTrim2 { get; set; }
        public DateTime? OutTimeLateTrim3 { get; set; }
        public DateTime? OutTimeLateHr { get; set; }
        public string WeekDay { get; set; }
        public bool? IsEdited { get; set; }
        public bool? IsNextDay { get; set; }
        public string DayType { get; set; }
        public DateTime? LunchOut { get; set; }
        public DateTime? LunchIn { get; set; }

        public virtual HrTimeTable Tt { get; set; }
    }
}
