using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter Numbers (enter 0 to stop):");
        
        do
        {
            Console.Write("Enter any positive integer: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)  // 
            {
                numbers.Add(input);
            }

        } while (input != 0);

       
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum: {sum}");

       
        if (numbers.Count > 0)  // 
        {
            float average = (float)sum / numbers.Count;  
            Console.WriteLine($"Average: {average}");
        }

       
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Maximum: {max}");
    }
}
