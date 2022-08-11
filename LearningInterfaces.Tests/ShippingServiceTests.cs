using System.Collections.ObjectModel;
using Moq;

namespace LearningInterfaces.Tests;

public class MockEmailService : IEmailService
{
    public void SendEmail(Customer customer, string emailBody)
    {
        Console.WriteLine($"Sending email to {customer.Email} ... with body {emailBody}");
        // Thread.Sleep(TimeSpan.FromSeconds(4));
    }
}

public class ShippingServiceTests
{
    [Fact]
    public void ShouldBeAbleToShipProducts()
    {
        var cart = FillCartWithSampleProducts();
        var bryan = new Customer("Bryan Ray", "bryan@bryanray.net");

        var mockEmailService = new Mock<IEmailService>();
        // var mockEmailService = new MockEmailService();
        
        var shippingService = new ShippingService(mockEmailService.Object);
        // shippingService.SetEmailService();
        // shippingService.EmailService = mockEmailService.Object;

        shippingService.ShipItems(cart, bryan);
        
        mockEmailService.Verify(
            x => x.SendEmail(It.Is<Customer>(x => x == bryan), It.IsAny<string>()), 
            Times.Exactly(cart.Count()));
    }
    
    IEnumerable<IProduct> FillCartWithSampleProducts()
    {
        Collection<IProduct> results = new()
        {
            new PhysicalProduct("iPad Pro"),
            new PhysicalProduct("Programming Book"),
            new PhysicalProduct("Kitten"),
            new DigitalProduct("Stardew Valley"),
        };

        return results;
    }
}