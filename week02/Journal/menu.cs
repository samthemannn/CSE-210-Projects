class Menu
{
    public int displayMenu()
    {
        textspeed.TypeText("Welcome to the Journal Program!");
        textspeed.TypeText("1. Write Entry");
        textspeed.TypeText("2. Display Entries");
        textspeed.TypeText("3. Save Entries");
        textspeed.TypeText("4. Load Entries");
        textspeed.TypeText("5. Quit");
        Console.Write("Please select an option: ");
        return int.Parse(Console.ReadLine());
    }

    public void displayGoodbye()
    {
        textspeed.TypeText("Goodbye!");
    }
}