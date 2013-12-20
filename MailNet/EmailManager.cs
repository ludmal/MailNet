#region License
/*
 **************************************************************
 *  Author: Ludmal de silva, 2010
 *          http://www.ludmal.com/
 *          twitter: @ludmal
 * 
 * Created: 12/11/2010
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 **************************************************************  
*/
#endregion

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
