using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrLeaveDocumentImages
    {
        public long? LeaveImageId { get; set; }
        public long? LeaveId { get; set; }
        public byte[] LeaveImage { get; set; }
        public string Extension { get; set; }
    }
}
