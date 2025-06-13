using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(); // Ensure there's a line break before "Breathe in"
            Console.Write("Breathe in...");
            ShowCountDown(4); // Pause for 4 seconds
            if (DateTime.Now >= endTime) break;

            Console.WriteLine();
            Console.Write("Now Breathe out...");
            ShowCountDown(6); // Pause for 6 seconds
            Console.WriteLine(); // Add a line break after "Breathe out"
        }
    }
}
