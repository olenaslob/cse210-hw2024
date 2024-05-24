// Base class for all types of activities
public class Activity
{
    // Common attributes for all activities
    protected DateTime date;
    protected int minutes;

    // Constructor to initialize activity details
    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    // Virtual method to calculate the distance (to be overridden in derived classes)
    public virtual double GetDistance()
    {
        return 0; // Base implementation returns 0
    }

    // Virtual method to calculate the speed (to be overridden in derived classes)
    public virtual double GetSpeed()
    {
        return 0; // Base implementation returns 0
    }

    // Virtual method to calculate the pace (to be overridden in derived classes)
    public virtual double GetPace()
    {
        return 0; // Base implementation returns 0
    }

    // Method to generate summary information
    public string GetSummary()
    {
        return $"{date.ToShortDateString()} {GetType().Name} ({minutes} min): Distance {GetDistance()}, Speed {GetSpeed()}, Pace: {GetPace()}";
    }
}
