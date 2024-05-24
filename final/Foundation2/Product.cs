public class Product
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    // Constructor to initialize product fields
    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to calculate the total cost of the product
    public double GetTotalCost()
    {
        return price * quantity;
    }

    // Property to get the product's name
    public string Name => name;

    // Property to get the product's ID
    public string Id => id;
}
