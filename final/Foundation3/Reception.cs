// Derived class for Reception events
public class Reception : Event
{
    // Additional attribute for Reception events
    private string rsvpEmail;

    // Constructor to initialize reception details
    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    // Method to generate full event message for Reception
    public override string GenerateFullMessage()
    {
        return $"{base.GenerateFullMessage()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}
