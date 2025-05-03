using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Number Game");
        Console.WriteLine("What is the magic Number");
        
        int magic_number= int.Parse(Console.ReadLine());
        Console.WriteLine($"You chose {magic_number} as your magic number " );
        
        Console.WriteLine("What is guess of the magic number");
        Console.Clear();


        int guess =0;
        
        
        int guess_count =0;
        Console.WriteLine("Please try and guess the number");

        while(guess!= magic_number)
        {
            Console.WriteLine("Please enter your guess");
            guess = int.Parse(Console.ReadLine());
            guess_count++;

            if (guess < magic_number)
            {
                Console.WriteLine($"The Guess {guess} is lower than the magic number") ;
                Console.WriteLine("Please Try again");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine($"The Guess {guess} is Higher than the magic number");
                Console.WriteLine("Please Try again");
            }
            else
            {
                Console.WriteLine("WOOOOHOOO YOU GUESSED THE RIGHT NUMBER!!!!!!! :)");
                Console.WriteLine($"Your Guess Count was {guess_count} guesses");
            }

        
        }   

    }
}
