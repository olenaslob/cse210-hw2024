// Derived class for Swimming activities
public class Swimming : Activity
{
    // Additional attribute for Swimming activities
    private int laps;

    // Constructor to initialize swimming details
    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    // Override method to calculate the distance for swimming
    public override double GetDistance()
    {
        // Distance in kilometers
        double distanceKm = laps * 50 / 1000.0;
        // Convert distance to miles
        double distanceMiles = distanceKm * 0.62;
        return distanceMiles;
    }

    // Override method to calculate the speed for swimming
    public override double GetSpeed()
    {
        // Speed in miles per hour
        return (GetDistance() / minutes) * 60;
    }

    // Override method to calculate the pace for swimming
    public override double GetPace()
    {
        // Pace in minutes per mile
        return minutes / GetDistance();
    }
}

