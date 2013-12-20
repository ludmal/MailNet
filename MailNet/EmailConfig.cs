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
