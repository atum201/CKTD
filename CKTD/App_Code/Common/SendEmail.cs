using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Summary description for SendEmail
/// </summary>
public class SendEmail
{
    public SendEmail()
    {

    }

    public static void Send(string email, string subject, string content)
    {
        var fromAddress = new MailAddress("buikhanhhuong18101985@gmail.com", "Minh Coin");
        var toAddress = new MailAddress(email);
        string fromPassword = "Shop@123";
        string body = content;

        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        };
        using (var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        })
        {

            smtp.Send(message);
        }
    }
}