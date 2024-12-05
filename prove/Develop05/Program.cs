using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop05 World!");
        Activity activity = new Activity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
        activity.OpeningMessage();
        activity.ShowCountDown(30);
    }
}