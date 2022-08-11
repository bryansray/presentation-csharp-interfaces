public class ShippingService
{
    // private IEmailService _emailService;

    public ShippingService(IEmailService emailService)
    {
        // _emailService = emailService;
        // _emailService = new EmailService();
    }

    public IEmailService EmailService { get; set; }
    
    public void ShipItems(IEnumerable<IProduct> cart, Customer customer)
    {
        foreach (var product in cart)
        {
            product.ShipItem(customer);
            
            if (EmailService != null)
                EmailService.SendEmail(customer, "Here's your damn product.");
        }
    }
}