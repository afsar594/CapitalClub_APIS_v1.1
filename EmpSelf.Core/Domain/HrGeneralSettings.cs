using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrGeneralSettings
    {
        public decimal GenId { get; set; }
        public string KeyValue { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ValueType { get; set; }
        public bool? BoolValue { get; set; }
        public decimal? NumValue { get; set; }
        public string TextValue { get; set; }
        public string TableName { get; set; }
    }
}
