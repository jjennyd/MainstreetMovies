using Group_6_Final_Project.DAL;
using System;
using System.Linq;
using System.Net.Mail;
using System.Net;

namespace Group_6_Final_Project.Utilities
{
    public static class EmailMessaging
    {
        public static void SendEmail(String emailSubject, String emailBody)
        {
            //https://www.c-sharpcorner.com/UploadFile/sourabh_mishra1/sending-an-e-mail-using-Asp-Net-mvc/
            //^^Very helpful reference



            //Create a variable for YOUR TEAM'S Email address
            //This is the address that will be SENDING the emails (the FROM address)
            String strFromEmailAddress = "fa23group6mis333k@gmail.com";

            //This is the app password for YOUR TEAM'S "fake" Gmail account
            //An app password is DIFFERENT than the password you set up when you created the account
            //You have to enable 2-factor authentication for the account, and then
            //set up the App Password (go into Account Settings and search for App Password)
            String strPassword = "xsizsgvothinimxm";

            //This is the name of the business from which you are sending
            String strCompanyName = "Main Street Movies";


            //Create an email client to send the emails
            //https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient?view=net-7.0
            //SmtpClient constructor takes two parameters: smtp server, and port #
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                //This is the SENDING email address and password
                //This will be your team's email address and password
                Credentials = new NetworkCredential(strFromEmailAddress, strPassword),
                EnableSsl = true
            };


            //Add anything that you need to the body of the message
            //emailBody is passed into the method as a parameter
            // /n is a new line – this will add some white space after the main body of the message
            //TODO: Change or remove the disclaimer below
            String finalMessage = emailBody + "\n\nThank you for your order!\n\n- Main Street Movies";

            //Create an email address object for the sender address
            //https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress.-ctor?view=net-7.0#system-net-mail-mailaddress-ctor(system-string-system-string)
            //MaleAddress constructor takes 2 parameters: the FROM email, and the Display name for the email
            MailAddress senderEmail = new MailAddress(strFromEmailAddress, strCompanyName);

            //Create a new mail message
            //https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailmessage?view=net-7.0
            //has many properties, but you can just use subject, sender, from, to and body
            MailMessage mm = new MailMessage();

            //Set the subject line of the message (including your team number)
            mm.Subject = "Group 6 - " + emailSubject;

            //Set the sender address
            mm.Sender = senderEmail;

            //Set the from address
            mm.From = senderEmail;

            //Add the recipient (passed in as a parameter) to the list of people receiving the email
            mm.To.Add(new MailAddress("fa23group6mis333k@gmail.com"));

            //Add the message (passed)
            mm.Body = finalMessage;

            //Send bundles up all properties from MailMessage and sends using Smtp parameters
            //send the message!
            client.Send(mm);
        }
    }
}