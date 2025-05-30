using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press [Enter] to start. Each press will hide 3 more words. Type 'quit' to exit.");

        Scripture scripture = new Scripture();
        string response = "";

        Console.WriteLine($"\nScripture Reference: {scripture.GetReference()}");
        Console.WriteLine(scripture.GetVerseText());

        while (response != "quit")
        {
            Console.WriteLine("\nPress [Enter] to hide more words or type 'quit' to exit:");
            response = Console.ReadLine()?.Trim().ToLower();

            if (response != "quit")
            {
                scripture.HideWords(3);
                Console.Clear();
                Console.WriteLine($"\nScripture Reference: {scripture.GetReference()}");
                Console.WriteLine(scripture.GetVerseText());
            }
        }

        Console.WriteLine("\nThanks for using the Scripture Memorizer!");
    }
}
