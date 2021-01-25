# Send-emails-with-ASP.NET-Core-3.1
Send Emails with ASP.NET. This application will send emails in plain text and will support attachements as well. 
We will be using Mailkit to send the emails. This is an ASP.NET Core 3.1 Web API Project

###############
#Project Notes#
###############

1. In Services/MailService.cs
******************************
Line 25 – 28 Creates a new object of MimeMessage and adds in the Sender, To Address and Subject to this object. 
We will be filling the message related data (subject, body) from the mailRequest and the data we get from our JSON File

Line 30 – 45 – If there are any attachments (files) in the request object, we transform the file to an attachment 
and add it to the mail message as an Attachment Object of Body Builder.

Line 46 – Here we the HTML part of the email from the Body property of the request.

Line 47 – Finally, add the attachment and HTML Body to the Body of the Email.
Add the other required information.

Line 51 – Send the Message using the smpt’s SendMailAsync Method.
