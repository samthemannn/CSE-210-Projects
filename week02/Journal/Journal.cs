using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.Json;

class Journal
{

    public List<JournalEntry> JournalEntries = new List<JournalEntry>();

    public void DisplayEntries()
    {
        foreach (JournalEntry entry in JournalEntries)
        {
            textspeed.TypeText($"Date: {entry.date}\n Prompt {entry.prompt}\n Response {entry.UserResponse}");

        }

    }
    public void SaveToFile(string fileName)
    {
        var Json = JsonSerializer.Serialize(JournalEntries, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
        File.WriteAllText($"{fileName}.json", Json);
        textspeed.TypeText("Journal saved successfully.");
    }

    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();
        textspeed.TypeText(prompt);
        string Response = Console.ReadLine();
        JournalEntry NewEntry = new JournalEntry();
        NewEntry.prompt = prompt;
        NewEntry.UserResponse = Response;
        string CurrentDay = GetDate();
        NewEntry.date = CurrentDay;
        JournalEntries.Add(NewEntry);
    }
    public string GetDate()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        return date;
    }
    public void LoadEntries()
    {
        try
        {


            string json = File.ReadAllText("May 2025 Journal.json");
            var entries = JsonSerializer.Deserialize<List<JournalEntry>>(json, new JsonSerializerOptions { IncludeFields = true });
            JournalEntries = entries;

        }
        catch { }
        
    }




}
    