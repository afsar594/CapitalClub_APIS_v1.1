using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSelf.Application.EmailNotifications
{
    public class ApplicationMailSettings
    {
        public string FromEmail { get; set; }
        public string DisplayName { get; set; }
        public string ApiKey { get; set; }
        public string TemplateId { get; set; }
        public string SupportEmail { get; set; }
    }

}
