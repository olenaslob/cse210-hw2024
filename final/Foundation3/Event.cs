// Base class for all types of events
public class Event
{
    // Common attributes for all events
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    // Constructor to initialize event details
    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // Method to generate standard event message
    public string GenerateStandardMessage()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.GetFullAddress()}";
    }

    // Method to generate full event message
    public virtual string GenerateFullMessage()
    {
        return GenerateStandardMessage();
    }

    // Method to generate short event description
    public string GenerateShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
