public interface IEmailService
{
    void SendEmail(Customer customer, string emailBody);
}