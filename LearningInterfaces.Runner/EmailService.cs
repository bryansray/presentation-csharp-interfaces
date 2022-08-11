public class EmailService : IEmailService
{
    public void SendEmail(Customer customer, string emailBody)
    {
        Console.WriteLine($"Sending email to {customer.Email} ... with body {emailBody}");
        Thread.Sleep(TimeSpan.FromSeconds(4));
    }
}