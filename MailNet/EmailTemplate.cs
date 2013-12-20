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

namespace MailNet {
    public class EmailTemplate {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string TemplateFileName { get; set; }

        public EmailFieldValueCollection FieldList { get; set; }

        public EmailTemplate() {
            this.From = string.Empty;
            this.To = string.Empty;
            this.Subject = string.Empty;
            this.Body = string.Empty;
            this.TemplateFileName = string.Empty;
            this.FieldList = new EmailFieldValueCollection();
        }

        public EmailTemplate(string to, string subject, string body)
            : this(string.Empty, to, subject, body) {
        }

        public EmailTemplate(string from, string to, string subject, string body) {
            this.From = from;
            this.To = to;
            this.Subject = subject;
            this.Body = body;
            this.TemplateFileName = string.Empty;
            this.FieldList = new EmailFieldValueCollection();
        }
    }
}
