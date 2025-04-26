using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your Grade");
        
        int userInput = int.Parse(Console.ReadLine());
        Console.WriteLine (userInput);
        if (userInput > 90)
        {  
            Console.WriteLine ("You have an A");
        }
        else if (userInput > 80)
        {
            Console.WriteLine("You have a B ");
        }
        else if (userInput > 70) 
        {
            Console.WriteLine ("You have a C");
        }
        else if (userInput >= 60)
        {
            Console.WriteLine ("You have a D");
        } 
        else 
        {
            Console.WriteLine ("You have a F");
        }

    }
}