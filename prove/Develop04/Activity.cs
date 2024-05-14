// Base class for all activities
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected static Dictionary<string, int> _activityLog = new Dictionary<string, int>(); // Log to keep track of activity counts

    // Constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _activityLog[_name] = 0; // Initialize activity count to 0
    }

    // Display starting message
    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity: {_description}");
        Console.WriteLine($"You will have this activity {_duration} times.");
        Thread.Sleep(2000);
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000);
    }

    // Display ending message
    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You've completed the {_name} activity for {_duration} times.");
        Thread.Sleep(2000);
        Console.WriteLine();
        _activityLog[_name]++; // Increment activity count
    }

    // Show spinner animation
    protected void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinner animation...");
        Thread.Sleep(seconds * 1000);
    }

    // Show countdown timer
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            Thread.Sleep(1000);
        }
    }
}