// Class representing an eternal goal (never complete)
class EternalGoal : Goal
{
    // Constructor to initialize the eternal goal
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // Override to record an event (does nothing for eternal goals)
    public override void RecordEvent()
    {
        // Always incomplete
    }

    // Override to check if the goal is complete (always false)
    public override bool IsComplete()
    {
        return false; // Never complete
    }

    // Override to get details of the goal
    public override string GetDetailsString()
    {
        return $"{_name}: {_description} (Points: {_points} each time)";
    }

    // Override to get string representation of the goal
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}
