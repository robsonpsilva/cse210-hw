using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        QuestionList q = new QuestionList();
        q.setQuestion("What was the best part of my day?");
        q.setQuestion("What would you like to do?");
        q.setQuestion("WHow have you seen God's hand working in your life today?");
        q.setQuestion("What is the best, kindest thing you did today?");

        Console.WriteLine($"{q.getQuestion(1)}");
    }
}