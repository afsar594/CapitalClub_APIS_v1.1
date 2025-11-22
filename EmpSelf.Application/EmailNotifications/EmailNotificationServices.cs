using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmpSelf.Application.EmailNotifications
{
   
    public class EmailNotificationServices : IEmailNotificationServices
    {
        private readonly ILogger<EmailNotificationServices> _logger;
        private readonly ApplicationMailSettings _mailSettings;
        EmailAddress from => new EmailAddress(_mailSettings.FromEmail, _mailSettings.DisplayName);
        public EmailNotificationServices(ILogger<EmailNotificationServices> logger, IOptions<ApplicationMailSettings> mailSettings)
        {
            _logger = logger;
            _mailSettings = mailSettings.Value;
        }

        public async Task<bool> SendMultipleTemplateEmailsToMultipleRecipientsAsync(List<EmailAddress> toEmails, string templateId, List<object> dynamicTemplateData, List<EmailAddress> bc = null, List<EmailAddress> cc = null)
        {
            try
            {
                var msg = MailHelper.CreateMultipleTemplateEmailsToMultipleRecipients(from, toEmails, templateId, dynamicTemplateData);

                if (cc != null && cc.Any())
                    msg.AddCcs(cc);
                if (bc != null && bc.Any())
                    msg.AddBccs(bc);
                return await SendEmailAsync(msg, toEmails.Select(te => te.Email));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error sending email: {ex.Message}");
                return false;
            }
        }

        private async Task<bool> SendEmailAsync(SendGridMessage message, IEnumerable<string> toEmails)
        {
            var client = new SendGridClient(_mailSettings.ApiKey);
            var response = await client.SendEmailAsync(message);

            if (response.IsSuccessStatusCode)
            {
                _logger.LogInformation(
                    "Email sent successfully to {Recipients}. Status Code: {StatusCode}",
                    string.Join(", ", toEmails),
                    response.StatusCode
                );
                return true;
            }

            var errorMessage = await response.Body.ReadAsStringAsync();
            _logger.LogError(
                "Failed to send email. Status Code: {StatusCode}, Error: {ErrorMessage}",
                response.StatusCode,
                errorMessage
            );

            return false;
        }


        public async Task<bool> SendSingleTemplateEmailToMultipleRecipientsAsync(List<EmailAddress> toEmails, string templateId, object dynamicTemplateData, List<EmailAddress> bc = null, List<EmailAddress> cc = null)
        {
            try
            {
                var msg = MailHelper.CreateSingleTemplateEmailToMultipleRecipients(from, toEmails, templateId, dynamicTemplateData);

                if (cc != null && cc.Any())
                    msg.AddCcs(cc);
                if (bc != null && bc.Any())
                    msg.AddBccs(bc);

                return await SendEmailAsync(msg, toEmails.Select(te => te.Email));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error sending email: {ex.Message}");
                return false;
            }
        }


        public async Task<bool> SendSingleEmailToMultipleRecipientsAsync(List<EmailAddress> toEmails, string subject, string message, List<EmailAddress> bc = null, List<EmailAddress> cc = null)
        {
            try
            {
                var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, toEmails, subject, message, message);

                if (cc != null && cc.Any())
                    msg.AddCcs(cc);
                if (bc != null && bc.Any())
                    msg.AddBccs(bc);

                return await SendEmailAsync(msg, toEmails.Select(te => te.Email));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error sending email: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> SendMultipleEmailToMultipleRecipientsAsync(List<EmailAddress> toEmails, List<string> subjects, string message, string htmlContent, List<Dictionary<string, string>> substitutions, List<EmailAddress> bc = null, List<EmailAddress> cc = null)
        {
            try
            {
                var msg = MailHelper.CreateMultipleEmailsToMultipleRecipients(from, toEmails, subjects, message, htmlContent, substitutions);

                if (cc != null && cc.Any())
                    msg.AddCcs(cc);
                if (bc != null && bc.Any())
                    msg.AddBccs(bc);

                return await SendEmailAsync(msg, toEmails.Select(te => te.Email));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error sending email: {ex.Message}");
                return false;
            }
        }
    }
}
