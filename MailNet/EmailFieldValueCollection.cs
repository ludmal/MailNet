using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailNet {
    public class EmailFieldValueCollection : List<EmailFieldValue> {
        public string Render(string body) { 
            if(this.Count > 0) {
                foreach (var item in this) {
                    body = body.Replace(item.FieldName, item.FieldValue);
                }
            }

            return body;
        }
    }
}
