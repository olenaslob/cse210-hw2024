// Class representing a checklist goal (requires multiple completions)
class ChecklistGoal : Goal
{
    private int _amountCompleted; // Number of times the goal has been completed
    private int _target; // Target number of completions
    private int _bonus; // Bonus points for completing the goal

    // Constructor to initialize the checklist goal
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Override to record an event (increments the completion count)
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    // Override to check if the goal is complete
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Override to get details of the goal
    public override string GetDetailsString()
    {
        return $"{(_amountCompleted >= _target ? "[X]" : "[ ]")} {_name}: {_description} (Completed {_amountCompleted}/{_target} times, Points: {_points}, Bonus: {_bonus})";
    }

    // Override to get string representation of the goal
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    // Method to get bonus points if the goal is complete
    public int GetBonus()
    {
        return IsComplete() ? _bonus : 0;
    }

    public int AmountCompleted { get; private set; }

    public void SetAmountCompleted(int amount)
    {
        AmountCompleted = amount;
    }
}
