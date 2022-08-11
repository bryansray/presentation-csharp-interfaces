
public record PhysicalProduct(string Title) : BaseProduct(Title) // IProduct
{

    public override void ShipItem(Customer customer)
    {
        Console.WriteLine($"Shipping product '{Title}' to '{customer.Name}' ");
    }
}