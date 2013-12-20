using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace MailNet {
    public class EmailConfig : ConfigurationSection {

        [ConfigurationProperty("enable", DefaultValue = "true", IsRequired = false)]
        public bool Enable {
            get {
                return Convert.ToBoolean(this["enable"]);
            }
        }

        [ConfigurationProperty("smtpServer", DefaultValue = "", IsRequired = false)]
        public string SmtpServer {
            get {
                return this["smtpServer"] as string;
            }
        }

        [ConfigurationProperty("isBodyHtml", DefaultValue = "true", IsRequired = false)]
        public bool IsBodyHtml {
            get {
                return Convert.ToBoolean(this["isBodyHtml"]);
            }
        }

        [ConfigurationProperty("from", DefaultValue = "", IsRequired = false)]
        public string From {
            get {
                return this["from"] as string;
            }
        }

        [ConfigurationProperty("url", DefaultValue = "", IsRequired = false)]
        public string Url {
            get {
                return this["url"] as string;
            }
        }

        [ConfigurationProperty("username", DefaultValue = "", IsRequired = false)]
        public string Username {
            get {
                return this["username"] as string;
            }
        }

        [ConfigurationProperty("password", DefaultValue = "", IsRequired = false)]
        public string Password {
            get {
                return this["password"] as string;
            }
        }

        [ConfigurationProperty("ssl", DefaultValue = "false", IsRequired = false)]
        public bool SSL {
            get {
                return Convert.ToBoolean(this["ssl"]);
            }
        }

        //[System.Configuration.ConfigurationProperty("JQueryFile", DefaultValue = "", IsRequired = false)]
        //public string JQueryFile {
        //    get {
        //        return this["JQueryFile"] as string;
        //    }
        //}

        //EmailConfigField element = null;

        public EmailConfig() {
            //element = new EmailConfigField();
        }

        [ConfigurationProperty("templatePath", DefaultValue = "", IsRequired = false)]
        public string TemplatePath {
            get {
                return this["templatePath"] as string;
            }
        }


        //[ConfigurationProperty("scripts", IsDefaultCollection = false)]
        //[ConfigurationCollection(typeof(CustomScriptCollection), AddItemName = "add",
        //    ClearItemsName = "clear",
        //    RemoveItemName = "remove")]
        //public CustomScriptCollection Elements {
        //    get {
        //        return (CustomScriptCollection)base["scripts"];
        //    }
        //}

    }
}
