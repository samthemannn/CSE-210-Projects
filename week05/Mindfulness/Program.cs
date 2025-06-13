using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:
        // 1. Non-repeating prompts/questions: Implemented in ReflectionActivity and ListingActivity.
        //    Prompts and questions are drawn from a list. Once used, they are moved to a 'used' list.
        //    When the original list is empty, it's refilled from the 'used' list, ensuring all items
        //    are shown before repetition within a session for that activity type.
        // 2. Increased countdown for ListingActivity: The initial countdown for the ListingActivity
        //    before the user starts listing items has been increased to 8 seconds (from the planned 5)
        //    to give a bit more thinking time.

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    continue; 
            }

            if (activity != null)
            {
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
        }
    }
}