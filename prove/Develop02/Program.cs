using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        QuestionList q = new QuestionList();
        

        Console.WriteLine($"{q.getRandomQuestion()}");
        Console.WriteLine($"{q.getRandomQuestion()}");
        Console.WriteLine($"{q.getRandomQuestion()}");
    }
}