using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailNet {
    public class EmailConfigField : System.Configuration.ConfigurationElement {
        /// <summary>
        /// Returns the setting value for the production environment.
        /// </summary>
        [System.Configuration.ConfigurationProperty("name", IsRequired = true)]
        public string Name {
            get {
                return this["name"] as string;
            }
        }

        [System.Configuration.ConfigurationProperty("value", IsRequired = true)]
        public string Value {
            get {
                return this["value"] as string;
            }
        }
    }
}
