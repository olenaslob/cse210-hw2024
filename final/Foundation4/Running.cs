// Derived class for Running activities
public class Running : Activity
{
    // Additional attribute for Running activities
    private double distance;

    // Constructor to initialize running details
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    // Override method to calculate the distance for running
    public override double GetDistance()
    {
        return distance;
    }

    // Override method to calculate the speed for running
    public override double GetSpeed()
    {
        return distance / minutes * 60; // Speed in miles per hour (mph)
    }

    // Override method to calculate the pace for running
    public override double GetPace()
    {
        return minutes / distance; // Pace in minutes per mile
    }
}
