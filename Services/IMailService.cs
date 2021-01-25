using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Send_Emails.Models;

namespace Send_Emails.Services
{
    interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
