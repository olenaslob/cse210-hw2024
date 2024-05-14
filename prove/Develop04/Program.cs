using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Helps you relax by walking you through breathing in and out slowly", 3);
        List<string> reflectionPrompts = new List<string> { "Think of a time when you stood up for someone else", "Think of a time when you did something really difficult", "Think of a time when you helped someone in need" };
        List<string> reflectionQuestions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?" };
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflection", "Helps you reflect on times in your life when you have shown strength and resilience", 3, reflectionPrompts, reflectionQuestions);
        List<string> listingPrompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?" };
        ListingActivity listingActivity = new ListingActivity("Listing", "Helps you reflect on the good things in your life by having you list as many things as you can in a certain area", 3, listingPrompts);
        List<string> gratitudeItems = new List<string> { "Family", "Health", "Nature", "Friendship", "Opportunities" };
        GratitudeActivity gratitudeActivity = new GratitudeActivity("Gratitude", "Helps you focus on things you are grateful for in your life", 3, gratitudeItems);

        while (true)
        {
            // Menu
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");

            Console.WriteLine("5. Quit");

            // User choice
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }

            // Perform selected activity
            switch (choice)
            {
                case 1:
                    breathingActivity.Run();
                    break;
                case 2:
                    reflectingActivity.Run();
                    break;
                case 3:
                    listingActivity.Run();
                    break;
                case 4:
                    gratitudeActivity.Run();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    return;
            }
        }
    }
}