using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
   public class CountModel
    {
        public int Approval { get; set; }
        public int Pending { get; set; }
        public int ServiceApproval { get; set; }
        public int ServicePending { get; set; }

    }
}
