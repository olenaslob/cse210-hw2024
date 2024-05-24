// Derived class for Lecture events
public class Lecture : Event
{
    // Additional attribute for Lecture events
    private string speaker;
    private int capacity;

    // Constructor to initialize lecture details
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // Method to generate full event message for Lecture
    public override string GenerateFullMessage()
    {
        return $"{base.GenerateFullMessage()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}
