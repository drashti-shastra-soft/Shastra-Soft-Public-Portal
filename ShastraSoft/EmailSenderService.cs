using Microsoft.Extensions.Options;
using ShastraSoft;
using ShastraSoft.Models;
using System.Net;
using System.Net.Mail;

public class EmailSenderService : IEmailSenderService
{
    private readonly SmtpSettings _settings;

    public EmailSenderService(IOptions<SmtpSettings> settings)
    {
        _settings = settings.Value;
    }

    public async Task SendEmailAsync(string subject, string htmlBody, string toEmail)
    {
        try
        {
            using var smtpClient = new SmtpClient(_settings.Host, _settings.Port)
            {
                Credentials = new NetworkCredential(_settings.Username, _settings.Password),
                EnableSsl = _settings.EnableSsl
            };

            using var mailMessage = new MailMessage
            {
                From = new MailAddress(_settings.FromEmail, _settings.FromName),
                Subject = subject,
                Body = htmlBody,
                IsBodyHtml = true
            };

            mailMessage.To.Add(toEmail);

            await smtpClient.SendMailAsync(mailMessage);
            await Task.CompletedTask;
        }
        catch (Exception)
        {
            throw; 
        }
    }
}
