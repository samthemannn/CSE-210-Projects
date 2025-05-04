using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi! What should I call you?");
        string userName = Console.ReadLine();

        DisplayWelcome(userName);

        Console.WriteLine($"{userName}, what is your favorite number?");
        int favoriteNumber = int.Parse(Console.ReadLine());
        int squaredNumber = SquareNumber(favoriteNumber);
        
        DisplayResult(userName, squaredNumber);
        DisplayWelcome(userName, favoriteNumber);
    }

    static void DisplayWelcome(string name)
    {
        Console.WriteLine($"Welcome {name}, nice to meet you!");
    }

    static void DisplayWelcome(string name, int number)
    {
        Console.WriteLine($"Awesome, {name}! Your favorite number is {number}.");
    }
    
     static int SquareNumber(int number)
     {
        return number * number;
     }


      static void DisplayResult(string name, int squaredNumber)
      {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
      }

}  
    

