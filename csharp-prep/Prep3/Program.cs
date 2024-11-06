using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int magic;
        int guess;
        bool stopGuessing = false;
        string opt;

        Random randomGenerator = new Random();
        magic = randomGenerator.Next(0, 100);
        while (stopGuessing == false) 
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            Console.Write("Would you like to end the game? Enter y for yes or n for no. ");
            opt = Console.ReadLine();
            if (opt == "y")
            {
                stopGuessing = true;
            }
        }
    }

        
}