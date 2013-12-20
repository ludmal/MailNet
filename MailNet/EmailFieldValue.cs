using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailNet {
    public class EmailFieldValue {
        public string FieldName { get; set; }
        public string FieldValue { get; set; }

        public EmailFieldValue(string fieldName, string fieldValue) {
            this.FieldName = string.Format("[{0}]",fieldName);
            this.FieldValue = fieldValue;
        }
    }
}
