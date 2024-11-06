using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        int studentGradePercentage;
        int resto;
        string letter;
        string signal;

        Console.Write("Type your student grade percentage! ");
        studentGradePercentage = int.Parse(Console.ReadLine());
        if (studentGradePercentage >= 90)
        {
            letter = "A";
        }
        else if (studentGradePercentage >= 80)
        {
            letter = "B";
        }
        else if (studentGradePercentage >= 70)
        {
            letter = "C";
        }
        else if (studentGradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
           letter = "F"; 
        }
        

        resto = studentGradePercentage%10;
        if (resto >= 7)
        {
            signal = "+";
        }
        else if ( resto <= 3)
        {
            signal = "-";
        }
        else
        {
            signal = "";
        }

        if (letter == "A")
        {
            if (resto <= 3)
            {
                letter += signal;
            }
        }
        else if (letter == "F")
        {
           letter = letter; 
        }
        else
        {
           letter += signal; 
        }

        Console.WriteLine($"Your grade is {letter}");

        if (studentGradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you have been approved!");
        }
        else
        {
            Console.WriteLine("You weren't approved, but don't give up, with determination you will get approval!");
        }

    }
}