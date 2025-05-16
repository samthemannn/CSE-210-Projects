using System.Xml.Linq;

class Program()
{
    static void Main(string[] args)

    {
        Journal journal = new Journal();

        Menu menu = new Menu();
        int menuchoice = -1;
     
        journal.LoadEntries();
     
        while (menuchoice != 5)
        {
            menuchoice = menu.displayMenu();
            switch (menuchoice)
            {
                case 1:
                    textspeed.TypeText("You chose to write an entry.");
                    journal.AddEntry();
                    journal.SaveToFile("May 2025 Journal");
                    break;
                case 2:
                    textspeed.TypeText("You chose to display entries.");
                    journal.DisplayEntries();
                    break;
                case 3:
                    textspeed.TypeText("You chose to save entries.");
                    break;
                case 4:
                    textspeed.TypeText("You chose to load entries.");
                    journal.LoadEntries();
                    journal.DisplayEntries();
                    break;
                case 5:
                    menu.displayGoodbye();
                    break;
                default:
                    textspeed.TypeText("Invalid choice. Please try again.");
                    break;

            }
        }
    }
}
