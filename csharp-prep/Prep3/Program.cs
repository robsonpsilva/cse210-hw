using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int magic;
        int guess = 1;
        bool stopGuessing = false;
        string opt;
        int count = 0;

        Random randomGenerator = new Random();
        while (stopGuessing == false)
        {
            magic = randomGenerator.Next(0, 100);
            while (magic != guess) 
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
                count++;
                
            }
            Console.WriteLine($"You made {count} attempts until you hit the magic number.");

            Console.Write("Would you like to end the game? Enter y for yes or n for no. ");
            opt = Console.ReadLine();
            if (opt == "y")
            {
                stopGuessing = true;
            }
            else
            {
                guess = 1;
                count = 0;
            }
        }
    }

        
}