public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    {
        _prompts = prompts;
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine($"Total times {_name} activity performed: {_activityLog[_name]}");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Think about the prompt and start listing items:");
        string input;
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        } while (!string.IsNullOrWhiteSpace(input));
        return items;
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Thread.Sleep(2000);
        Console.WriteLine("You have 10 seconds to start listing...");
        ShowCountDown(10);
        Console.WriteLine("Time's up!");
        List<string> items = GetListFromUser();
        Console.WriteLine($"Number of items listed: {items.Count}");
        DisplayEndingMessage();
    }
}