public class GratitudeActivity : Activity
{
    private List<string> _gratitudeItems;

    public GratitudeActivity(string name, string description, int duration, List<string> gratitudeItems) : base(name, description, duration)
    {
        _gratitudeItems = gratitudeItems;
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine($"Total times {_name} activity performed: {_activityLog[_name]}");
    }

    private string GetRandomGratitudeItem()
    {
        Random random = new Random();
        return _gratitudeItems[random.Next(_gratitudeItems.Count)];
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i++)
        {
            string item = GetRandomGratitudeItem();
            Console.WriteLine($"Think about: {item}");
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}