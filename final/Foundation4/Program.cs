using System;

class Program
{
    public static void Main()
    {
        // Create activities of each type
        Activity runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 12.0);
        Activity swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 30, 10);

        // Put activities in a list
        var activities = new List<Activity> { runningActivity, cyclingActivity, swimmingActivity };

        // Display summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}