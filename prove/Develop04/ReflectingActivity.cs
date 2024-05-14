public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedQuestions = new List<string>();

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine($"Total times {_name} activity performed: {_activityLog[_name]}");
    }

    private string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }
        Random random = new Random();
        string prompt;
        do
        {
            prompt = _prompts[random.Next(_prompts.Count)];
        } while (_usedPrompts.Contains(prompt));
        _usedPrompts.Add(prompt);
        return prompt;
    }

    private string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }
        Random random = new Random();
        string question;
        do
        {
            question = _questions[random.Next(_questions.Count)];
        } while (_usedQuestions.Contains(question));
        _usedQuestions.Add(question);
        return question;
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i++)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"Reflect on: {prompt}");
            Thread.Sleep(2000);
            string question = GetRandomQuestion();
            Console.WriteLine($"Question: {question}");
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}