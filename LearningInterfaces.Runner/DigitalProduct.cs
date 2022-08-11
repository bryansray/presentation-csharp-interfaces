public record DigitalProduct(string Title) : BaseProduct(Title) // IProduct
{
    public override void ShipItem(Customer customer)
    {
        Console.WriteLine($"Email digital product '{Title}' to '{customer.Email}' ");
    }
}