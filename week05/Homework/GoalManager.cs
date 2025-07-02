using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals have been created yet.");
            return;
        }
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals have been created yet.");
            return;
        }
        Console.WriteLine("\nYour Goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points) || points < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer for points.");
            Console.Write("What is the amount of points associated with this goal? ");
        }

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target;
                while (!int.TryParse(Console.ReadLine(), out target) || target <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer for the target amount.");
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                }
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus;
                while (!int.TryParse(Console.ReadLine(), out bonus) || bonus < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer for the bonus.");
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                }
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals available to record an event for. Please create a goal first.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            int pointsEarned = _goals[goalIndex - 1].RecordEvent();
            _score += pointsEarned;
            // DisplayPlayerInfo(); // Already displayed at the start of the loop
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score); // Save the current score
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"File not found: {filename}");
            return;
        }

        try
        {
            _goals.Clear(); // Clear existing goals before loading
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length > 0)
            {
                if (!int.TryParse(lines[0], out _score))
                {
                    Console.WriteLine("Error: Invalid score format in file. Starting with score 0.");
                    _score = 0;
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    try // Add a try-catch block for each line to skip corrupted lines
                    {
                        string[] parts = lines[i].Split(':');
                        if (parts.Length < 2) { Console.WriteLine($"Warning: Skipping malformed line {i+1}: {lines[i]}"); continue; }

                        string goalType = parts[0];
                        string[] goalDetails = parts[1].Split(',');

                        string name = goalDetails[0];
                        string description = goalDetails[1];
                        
                        if (!int.TryParse(goalDetails[2], out int points))
                        { Console.WriteLine($"Warning: Invalid points for goal '{name}'. Skipping line {i+1}."); continue; }

                        if (goalType == "SimpleGoal")
                        {
                            if (goalDetails.Length < 4 || !bool.TryParse(goalDetails[3], out bool isComplete))
                            { Console.WriteLine($"Warning: Invalid data for SimpleGoal '{name}'. Skipping line {i+1}."); continue; }
                            _goals.Add(new SimpleGoal(name, description, points, isComplete));
                        }
                        else if (goalType == "EternalGoal")
                        {
                            // EternalGoal only needs name, description, points which are already parsed
                             _goals.Add(new EternalGoal(name, description, points));
                        }
                        else if (goalType == "ChecklistGoal")
                        {
                            if (goalDetails.Length < 6 || 
                                !int.TryParse(goalDetails[3], out int bonus) ||
                                !int.TryParse(goalDetails[4], out int target) ||
                                !int.TryParse(goalDetails[5], out int amountCompleted))
                            { Console.WriteLine($"Warning: Invalid data for ChecklistGoal '{name}'. Skipping line {i+1}."); continue; }
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                        }
                        else
                        {
                            Console.WriteLine($"Warning: Unknown goal type '{goalType}' in file. Skipping line {i+1}.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing line {i+1} from file: {lines[i]}. Details: {ex.Message}. Skipping this goal.");
                    }
                }
            }
            Console.WriteLine($"Goals loaded from {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
            // Potentially reset score and goals if loading fails critically
            _score = 0;
            _goals.Clear();
        }
    }
}
