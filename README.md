Obsolete - Please use [AWS.Net with EmailMessage class](https://github.com/ludmal/AWS.Net)

MailNet
=======
Lighweight Email framework for Web Apps

Step 1:
---------------
Configure the web.config file with MailNet settings.
(Please check the sample webapp's web.config file)

Step 2:
---------------
Design your HTML template (Please check the sample webapp's email_templates folder)

Step 3:
---------------
Create and Send your HTML template

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


follow me Twitter : @ludmal
