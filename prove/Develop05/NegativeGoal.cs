// Class representing a negative goal (penalizes the player)
class NegativeGoal : Goal
{
    private bool _isComplete; // Flag indicating if the goal is complete

    // Constructor to initialize the negative goal
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Override to record an event (marks the goal as complete)
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Override to check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Override to get details of the goal
    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name}: {_description} (Penalty: {_points} points)";
    }

    // Override to get string representation of the goal
    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_name},{_description},{_points},{_isComplete}";
    }
}
