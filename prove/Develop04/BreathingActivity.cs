public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine($"Total times {_name} activity performed: {_activityLog[_name]}");
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}