using System.Net.Mail;

namespace BlazorIdentityApp.Services
{
    public class MailService
    {
        private void SendMail()
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
                }
            }
        }

    }
}
