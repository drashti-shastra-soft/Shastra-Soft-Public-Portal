namespace ShastraSoft
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(string subject, string htmlBody, string toEmail);
    }
}
