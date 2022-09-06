using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using BlazorIdentityApp;
using BlazorIdentityApp.Shared;
using System.Net.Mail;

namespace BlazorIdentityApp.Pages
{
    public partial class Index
    {
            private string Message { get; set; } = "";
            private void SendMail()
            {
                try
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("salimovkhayal@gmail.com");
                        mail.To.Add("selimovxeyal@gmail.com");
                        mail.Subject = "Sending mail testing";
                        mail.Body = "<h1>Salam</h1>";
                        mail.IsBodyHtml = true;
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new System.Net.NetworkCredential("salimovkhayal@gmail.com", "iqepqgykafupydyf");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            Message = "Mail Sent";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Message = ex.Message;
                }
            }
        
    }
}