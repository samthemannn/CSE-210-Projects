using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input your first name");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Your first name is: {firstName}");
        Console.WriteLine("Input Your Last Name");
        string lastName = Console.ReadLine();
        Console .WriteLine($"Your last name is: {lastName}");
        Console .WriteLine($"Your full name is {firstName} , {lastName}");
    }
}