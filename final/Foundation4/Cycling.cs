// Derived class for Cycling activities
public class Cycling : Activity
{
    // Additional attribute for Cycling activities
    private double speed;

    // Constructor to initialize cycling details
    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    // Override method to calculate the distance for cycling
    public override double GetDistance()
    {
        // Distance in miles = (speed * minutes) / 60 (to convert minutes to hours)
        return (speed * minutes) / 60;
    }

    // Override method to calculate the speed for cycling
    public override double GetSpeed()
    {
        // Speed in mph = speed
        return speed;
    }

    // Override method to calculate the pace for cycling
    public override double GetPace()
    {
        // Pace in minutes per mile = 60 / speed
        return 60 / speed;
    }
}
