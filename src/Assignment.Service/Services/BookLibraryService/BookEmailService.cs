using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

public class BookEmailService
{
    public async Task SendEmail(string toAddr, string bookTitle, DateTime returnDate)
    {
        try
        {
            string subject = "Book Borrowed Confirmation";
            string mailbody = $"Hello,\n\nYou have borrowed the book '{bookTitle}'.\nPlease make sure to return it by {returnDate:yyyy-MM-dd}.\n\nRegards,\nThe Library";

            MailMessage message = new MailMessage("your-email@example.com", toAddr);
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = false;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential("sumaiya.m@spurtreetech.com", "Summi_47");

            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;

            await client.SendMailAsync(message);

            Console.WriteLine("Email sent successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending email: {ex.Message}");
        }
    }
}
