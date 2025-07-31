using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrAirTicketMaster
    {
        public long? Atid { get; set; }
        public long? Lsid { get; set; }
        public long? Staffid { get; set; }
        public long? FlyFromId { get; set; }
        public long? FlyToId { get; set; }
        public DateTime? DepDate { get; set; }
        public DateTime? RetDate { get; set; }
        public double? NoOfTicket { get; set; }
        public DateTime? LastTicketTaken { get; set; }
        public string Remarks { get; set; }
        public double? Amount { get; set; }
        public bool? Ticket { get; set; }
        public long? RetFlyFromId { get; set; }
        public long? RetFlyToId { get; set; }
        public bool? IsOneWay { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? TicketSettDate { get; set; }
        public double? AvailableTicket { get; set; }
    }
}
