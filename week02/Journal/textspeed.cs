public static class textspeed
{


    public static void TypeText(string text, int delayMilliseconds= 5)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delayMilliseconds);

        }
        Console.WriteLine(); 
    }






}