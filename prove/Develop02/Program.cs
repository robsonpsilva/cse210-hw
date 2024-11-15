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
        q.setQuestion("Which scripture stood out to you the most today? Why?");
        q.setQuestion("What has worried you most today? And how can you invite God to help you?");
        q.setQuestion("What fact or action helped you get closer to your family?");
        q.setQuestion("What did you do today that can increase your self-sufficiency?");
        q.setQuestion("What interesting place have you been today?");
        q.setQuestion("What happened today that helped your faith grow?");

        Console.WriteLine($"{q.getQuestion(1)}");
    }
}