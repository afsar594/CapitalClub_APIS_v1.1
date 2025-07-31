using System;
using System.Collections.Generic;

namespace EmpSelf.Core.Domain
{
    public partial class HrSalaryHead
    {
        public HrSalaryHead()
        {
            HrPayrollDetails = new HashSet<HrPayrollDetails>();
            HrSalaryPackage = new HashSet<HrSalaryPackage>();
        }

        public long Shid { get; set; }
        public string Shname { get; set; }
        public string FldName { get; set; }
        public string Nature { get; set; }
        public bool? Fixed { get; set; }
        public long? SortNo { get; set; }
        public string ShortName { get; set; }
        public bool? AbsentDeduct { get; set; }
        public string Remarks { get; set; }
        public string SalObject { get; set; }
        public bool? DontShowWps { get; set; }
        public string DisplayName { get; set; }

        public virtual ICollection<HrPayrollDetails> HrPayrollDetails { get; set; }
        public virtual ICollection<HrSalaryPackage> HrSalaryPackage { get; set; }
    }
}
