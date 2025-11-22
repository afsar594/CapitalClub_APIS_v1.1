using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmpSelf.Application.EmailNotifications
{
    public interface IEmailNotificationServices
    {
        public interface IEmailNotificationServices
        {
            Task<bool> SendMultipleTemplateEmailsToMultipleRecipientsAsync(List<EmailAddress> toEmails, string templateId, List<object> dynamicTemplateData, List<EmailAddress> bc = null, List<EmailAddress> cc = null);
            Task<bool> SendSingleTemplateEmailToMultipleRecipientsAsync(List<EmailAddress> toEmails, string templateId, object dynamicTemplateData, List<EmailAddress> bc = null, List<EmailAddress> cc = null);

            Task<bool> SendMultipleEmailToMultipleRecipientsAsync(List<EmailAddress> toEmails, List<string> subject, string message, string htmlContent, List<Dictionary<string, string>> substitutions, List<EmailAddress> bc = null, List<EmailAddress> cc = null);
            Task<bool> SendSingleEmailToMultipleRecipientsAsync(List<EmailAddress> toEmails, string subject, string message, List<EmailAddress> bc = null, List<EmailAddress> cc = null);
        }
    }
}
