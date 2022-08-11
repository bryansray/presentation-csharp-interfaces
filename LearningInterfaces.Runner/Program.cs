// See https://aka.ms/new-console-template for more information

using System.Collections.ObjectModel;

var cart = FillCartWithSampleProducts();
var bryan = new Customer("Bryan Ray", "bryan@bryanray.net");

foreach (var product in cart)
{
    product.ShipItem(bryan);
}


IEnumerable<IProduct> FillCartWithSampleProducts()
{
    Collection<IProduct> results = new()
    {
        new PhysicalProduct("iPad Pro"),
        new PhysicalProduct("Programming Book"),
        new PhysicalProduct("Kitten"),
        new DigitalProduct("Stardew Valley")
    };

    return results;
}