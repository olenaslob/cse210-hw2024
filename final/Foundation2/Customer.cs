public class Customer
{
    private string name;
    private Address address;

    // Constructor to initialize customer fields
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Property to get the customer's name
    public string Name => name;

    // Property to get the customer's address
    public Address Address => address;
}
