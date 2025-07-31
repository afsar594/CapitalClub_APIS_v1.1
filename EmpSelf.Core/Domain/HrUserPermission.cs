using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrUserPermission
    {
        public long Upid { get; set; }
        public long? UserId { get; set; }
        public int? FormNameId { get; set; }
        public bool? Upallow { get; set; }
        public bool? Upview { get; set; }
        public bool? Upadd { get; set; }
        public bool? Upedit { get; set; }
        public bool? Updelete { get; set; }
        public bool? Upprint { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }

        public virtual HrUsers User { get; set; }
    }
}
