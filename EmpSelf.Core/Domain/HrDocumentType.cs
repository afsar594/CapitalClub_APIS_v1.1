using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrDocumentType
    {
        public long DocumentTypeId { get; set; }
        public string DocumentType { get; set; }
        public bool DefaultType { get; set; }
        public bool? AppDocument { get; set; }
    }
}
