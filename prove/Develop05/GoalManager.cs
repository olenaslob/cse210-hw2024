using System;
using System.Collections.Generic;
using System.IO;

// Class to manage goals and player information
class GoalManager
{
    private List<Goal> _goals; // List of goals
    private int _score; // Player's score
    private int _xp; // Player's experience points
    private int _level; // Player's level

    // Constructor to initialize the goal manager
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _xp = 0;
        _level = 1;
    }

    // Method to start the program
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Method to display player information
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Experience Points (XP): {_xp}");
        Console.WriteLine($"Level: {_level}");
    }

    // Method to list details of all goals
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Method to create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            case "4":
                _goals.Add(new NegativeGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid option. Goal not created.");
                break;
        }
    }

    // Method to record an event for a goal
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Select the goal to record an event for: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            selectedGoal.RecordEvent();

            if (selectedGoal is NegativeGoal)
            {
                _score -= selectedGoal.GetPoints();
            }
            else
            {
                _score += selectedGoal.GetPoints();
                _xp += 10;
                CheckLevelUp();
            }

            if (selectedGoal is ChecklistGoal checklistGoal)
            {
                if (checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetBonus();
                }
            }

            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    // Method to check and handle leveling up
    private void CheckLevelUp()
    {
        int xpNeeded = _level * 100;
        if (_xp >= xpNeeded)
        {
            _xp -= xpNeeded;
            _level++;
            Console.WriteLine($"Congratulations! You've reached level {_level}!");
        }
    }

    // Method to save goals to a file
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_xp);
            writer.WriteLine(_level);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    // Method to load goals from a file
    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
    {
        Console.WriteLine("No saved goals found.");
        return;
    }

    string[] lines = File.ReadAllLines("goals.txt");
    _score = int.Parse(lines[0]);
    _xp = int.Parse(lines[1]);
    _level = int.Parse(lines[2]);
    _goals = new List<Goal>();

    for (int i = 3; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split(':');
        string goalType = parts[0];
        string[] goalData = parts[1].Split(',');

        switch (goalType)
        {
            case "SimpleGoal":
                SimpleGoal simpleGoal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                if (bool.Parse(goalData[3]))
                    simpleGoal.RecordEvent();
                _goals.Add(simpleGoal);
                break;
            case "EternalGoal":
                _goals.Add(new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2])));
                break;
            case "ChecklistGoal":
                ChecklistGoal checklistGoal = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[4]), int.Parse(goalData[5]));
                checklistGoal.SetAmountCompleted(int.Parse(goalData[3]));
                _goals.Add(checklistGoal);
                break;
            case "NegativeGoal":
                NegativeGoal negativeGoal = new NegativeGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                if (bool.Parse(goalData[3]))
                    negativeGoal.RecordEvent();
                _goals.Add(negativeGoal);
                break;
            default:
                Console.WriteLine($"Unknown goal type: {goalType}");
                break;
        }
    }

        Console.WriteLine("Goals loaded successfully.");
    }
}
