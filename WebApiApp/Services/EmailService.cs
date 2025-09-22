﻿using System.Net;
using System.Net.Mail;

namespace WebApiApp.Services;

public class EmailService: IEmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }


    public async Task SendEmailAsync(string to, string subject, string body)
    {
        var from = _configuration["EmailSettings:From"];
        var password = _configuration["EmailSettings:Password"];
        var server = _configuration["EmailSettings:SmtpServer"];
        var port = Convert.ToInt32(_configuration["EmailSettings:Port"]);

        var message = new MailMessage();

        message.From = new MailAddress(from);

        message.To.Add(to);

        message.Subject = subject;
        message.Body = body;
        message.IsBodyHtml = true;

        SmtpClient smtpClient = new SmtpClient(server, port);
        smtpClient.Credentials = new NetworkCredential(from, password);
        smtpClient.EnableSsl = true;

        await smtpClient.SendMailAsync(message);


    }
}
