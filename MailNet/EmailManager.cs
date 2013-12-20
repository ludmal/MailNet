using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Reflection;
using System.Configuration;
using System.Web;

namespace MailNet {
    public class EmailManager {

        public static void SendEmail(EmailTemplate template) {
            EmailConfig logConfig = (EmailConfig)ConfigurationManager.GetSection("mailnet");
            string body = string.Empty;
            string path = string.Format(@"{0}{1}", logConfig.TemplatePath, template.TemplateFileName);

            path = HttpContext.Current.Server.MapPath(path);

            using (StreamReader reader = new StreamReader(path)) {
                body = reader.ReadToEnd();
            }

            body = template.FieldList.Render(body);
            SendEmail(template.From, template.To, template.Subject, body);
        }

        public static void SendEmail(string to, string subject, string body) {
            SendEmail(string.Empty, to, subject, body);
        }

        public static void SendEmail(string from, string to, string subject, string body) {
            SendEmail(from, to, subject, body, true);
        }

        public static void SendEmail(string from, string to, string subject, string body, bool isBodyHtml) {
            EmailConfig logConfig = (EmailConfig)ConfigurationManager.GetSection("mailnet");

            if (logConfig.Enable) {
                MailMessage mail = new MailMessage(from == string.Empty ? logConfig.From : from, to);
                mail.Subject = subject;
                mail.IsBodyHtml = isBodyHtml;
                mail.Body = body;
                SmtpClient c = new SmtpClient(logConfig.SmtpServer);
                c.Send(mail);
            }
        }
    }
}
