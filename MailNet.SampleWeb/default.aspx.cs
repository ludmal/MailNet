using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailNet.SampleWeb {
    public partial class _default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            try {

                //Create the template 
                EmailTemplate welcome = new EmailTemplate();
                welcome.From = "Ludmal@gmail.com";
                welcome.To = "ludmal.desilva@airliquide.com";
                welcome.Subject = "Welcome to MailNet";
                welcome.TemplateFileName = "welcome.htm";

                //Add the fields for the template
                welcome.FieldList.Add(new EmailFieldValue("name", "Ludmal"));
                welcome.FieldList.Add(new EmailFieldValue("url", "http://www.ludmal.com"));
                
                //Send the email, Remember to configure the settings in the webconfig section
                EmailManager.SendEmail(welcome);

            } catch (Exception ex) {
                this.Label1.Text = ex.Message;
                
            }
        }
    }
}