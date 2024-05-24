// Address class to represent event addresses
public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor to initialize address fields
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Method to return the full address as a string
    public string GetFullAddress()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}
