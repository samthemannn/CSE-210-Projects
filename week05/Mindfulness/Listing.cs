using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random;
    private List<string> _usedPrompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _usedPrompts = new List<string>();
    }

    private string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(_usedPrompts); // Refill prompts
            _usedPrompts.Clear();
        }
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        _usedPrompts.Add(prompt);
        return prompt;
    }

    public override void Run()
    {
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(8); // Increased countdown for thinking time

        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine(); // Add a line break before prompting for the first item
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item)) // Allow users to press Enter if they can't think of more
            {
                if (DateTime.Now >= endTime) break; // if time is up, break
                // if time is not up, but they pressed enter, maybe they are just pausing
                // or decided not to add more for now. We can let them continue if time permits
                // or simply break if we want to end when they press enter on an empty line.
                // For now, let's assume they might just be pausing and continue the loop
                // until time is up.
            } else {
                items.Add(item);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");
        Console.WriteLine();
    }
}
