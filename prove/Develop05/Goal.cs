// Abstract base class representing a goal
abstract class Goal
{
    protected string _name; // Name of the goal
    protected string _description; // Description of the goal
    protected int _points; // Points awarded for completing the goal

    // Constructor to initialize the goal
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Abstract method to record an event (to be implemented by subclasses)
    public abstract void RecordEvent();
    // Abstract method to check if the goal is complete (to be implemented by subclasses)
    public abstract bool IsComplete();
    // Virtual method to get details of the goal
    public virtual string GetDetailsString()
    {
        return $"{_name}: {_description}";
    }
    // Abstract method to get string representation of the goal (for saving/loading)
    public abstract string GetStringRepresentation();
    // Method to get points for the goal
    public int GetPoints()
    {
        return _points;
    }
}
