using System;
using System.Net;
using System.Net.Mail;
namespace SOLID_Principles
{
    internal class EmailNotification
    {
        public static void SendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                mail.From = new MailAddress("mayura.sonar83@gmail.com");
                mail.To.Add(new MailAddress("mayura.sonar83@gmail.com"));
                mail.Subject = "Single Responsibility Demo!!";
                mail.IsBodyHtml = true;
                mail.Body = "We will be discussing SOLID Principle in today's session!!";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("mayura.sonar83@gmail.com", "Mayura@123");
                smtp.Send(mail);
                Console.WriteLine("Email Sent Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
