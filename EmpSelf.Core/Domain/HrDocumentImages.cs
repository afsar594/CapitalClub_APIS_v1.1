using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDocumentImages
    {
        public long DocImageId { get; set; }
        public long? DocumentId { get; set; }
        public byte[] DocImage { get; set; }
        public string Extension { get; set; }

        public virtual HrDocumentMaster Document { get; set; }
    }
}
