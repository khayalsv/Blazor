using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace BlazorIdentityApp.Services
{
    public interface IEmailService
    {
        void Send(string to, string subject, string html);
    }

    public class EmailService : IEmailService
    {
        public void Send(string to, string subject, string html)
        {
            //create message
            var email=new MimeMessage();
            email.From.Add(MailboxAddress.Parse("salimovkhayal@gmail.com"));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            //send email
            var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("salimovkhayal@gmail.com", "iqepqgykafupydyf");
            smtp.Send(email);
            smtp.Disconnect(true);



         
        }
    }
}
