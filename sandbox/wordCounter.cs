class WordCounter
{
    public void DisplayWords()
    {
        Console.WriteLine(word);
    }

    public int CountSingleWord(string searchWord)
    {
        int count = 0;
        foreach (string word in _words)
        {
            if (word == searchWord)
            {
                count++;
            }
        }
    }

}