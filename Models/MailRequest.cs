using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Send_Emails.Models
{
    public class MailRequest
    {
        // parameters such as email, subject, body, and list of attachements in the request model
        // so that these data can be passed on to the service layer
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}
