// Derived class for OutdoorGathering events
public class OutdoorGathering : Event
{
    // Additional attribute for OutdoorGathering events
    private string weatherForecast;

    // Constructor to initialize outdoor gathering details
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    // Method to generate full event message for OutdoorGathering
    public override string GenerateFullMessage()
    {
        return $"{base.GenerateFullMessage()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}
