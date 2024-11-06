using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int magic;
        int guess;

        Console.Write("What is the magic number? ");
        magic = int.Parse(Console.ReadLine());

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

    }
}