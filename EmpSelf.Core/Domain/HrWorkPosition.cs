using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrWorkPosition
    {
        public HrWorkPosition()
        {
            HrUsers = new HashSet<HrUsers>();
        }

        public string WorkPosition { get; set; }
        public int WorkPositionId { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }

        public virtual ICollection<HrUsers> HrUsers { get; set; }
    }
}
