public abstract record BaseProduct(string Title) : IProduct
{
    public string Title { get; init; } = Title;

    public abstract void ShipItem(Customer customer);
}