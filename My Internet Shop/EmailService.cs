﻿using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using static MyInternetShop.Storage;

namespace MyInternetShop
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "romaXXX2012@rambler.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.rambler.ru", 465, true);
                await client.AuthenticateAsync("romaXXX2012@rambler.ru", EPW);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
