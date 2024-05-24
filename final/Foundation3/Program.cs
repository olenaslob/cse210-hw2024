using System;

// Program class to demonstrate event creation and messaging
public class Program
{
    public static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        // Create events of each type
        Event lectureEvent = new Lecture("Introduction to AI", "Learn the basics of artificial intelligence", new DateTime(2024, 5, 25), new TimeSpan(10, 0, 0), address1, "John Doe", 50);
        Event receptionEvent = new Reception("Networking Reception", "Networking event for professionals", new DateTime(2024, 6, 15), new TimeSpan(18, 0, 0), address2, "info@example.com");
        Event outdoorGatheringEvent = new OutdoorGathering("Summer Picnic", "Enjoy a day of fun in the sun", new DateTime(2024, 7, 20), new TimeSpan(12, 0, 0), address1, "Sunny with a high of 85°F");

        // Display messages for each event
        Console.WriteLine("Standard Message for Lecture:");
        Console.WriteLine(lectureEvent.GenerateStandardMessage());
        Console.WriteLine();

        Console.WriteLine("Full Message for Lecture:");
        Console.WriteLine(lectureEvent.GenerateFullMessage());
        Console.WriteLine();

        Console.WriteLine("Short Description for Lecture:");
        Console.WriteLine(lectureEvent.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Message for Reception:");
        Console.WriteLine(receptionEvent.GenerateStandardMessage());
        Console.WriteLine();

        Console.WriteLine("Full Message for Reception:");
        Console.WriteLine(receptionEvent.GenerateFullMessage());
        Console.WriteLine();

        Console.WriteLine("Short Description for Reception:");
        Console.WriteLine(receptionEvent.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Message for Outdoor Gathering:");
        Console.WriteLine(outdoorGatheringEvent.GenerateStandardMessage());
        Console.WriteLine();

        Console.WriteLine("Full Message for Outdoor Gathering:");
        Console.WriteLine(outdoorGatheringEvent.GenerateFullMessage());
        Console.WriteLine();

        Console.WriteLine("Short Description for Outdoor Gathering:");
        Console.WriteLine(outdoorGatheringEvent.GenerateShortDescription());
    }
}
