using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions","Section 7.3","Problems 8-19" );
        Console.WriteLine(mathAssignment.getSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters","European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetWritingAssignment());
    }
}