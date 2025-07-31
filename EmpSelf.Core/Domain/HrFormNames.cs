using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrFormNames
    {
        public decimal FormId { get; set; }
        public string FormName { get; set; }
        public string FormAlias { get; set; }
        public string MenuName { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsMenuVisible { get; set; }
        public string FormType { get; set; }
        public long? CategoryId { get; set; }
    }
}
