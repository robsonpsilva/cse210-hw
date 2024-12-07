using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop05 World!");

        //Initializing components
        
        //Initializing breathing activity
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
        

        //Initializing reflecting activity
        List<string> prompts = new List<string>();
        //Loading the prompt list
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        
        //Loading the questions list
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");        

        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        30,prompts,questions);

        //Initializing listing activity
        prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        ListingActivity listingActivity = new ListingActivity("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        30, prompts); 
        
        //Creating the main menu

        bool flag = true;

        while (flag)
        {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("\t1. Start breathing activity");
                Console.WriteLine("\t2. Start reflecting activity");
                Console.WriteLine("\t3. Start listing activity");
                Console.WriteLine("\t4. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();
            
                if (choice == "1")
                {
                    Console.Clear();
                    //Breathing activity code session
                    breathingActivity.Run();
                    Console.Clear();
                }
                else if(choice == "2")
                {
                    //Reflecting activity code
                    reflectingActivity.Run();
                    Console.Clear();
                }
                else if (choice == "3")
                {
                    //Listing activity code
                    listingActivity.Run();
                }
                else if(choice == "4")
                {
                    flag = false; //Command to exit
                }
                else{
                    //Invalid Command
                    Console.Write("Invalid option, press a key to continue!");
                    Console.ReadLine();
                }

        }

    }
}

