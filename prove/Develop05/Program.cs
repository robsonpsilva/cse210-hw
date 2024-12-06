using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop05 World!");

        //Creating the main menu

        bool flag = true;

        while (flag)
        {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("\t1. Start breathing activity");
                Console.WriteLine("\t2. Start reflecting activity");
                Console.WriteLine("\t3. Start listing activity");
                Console.WriteLine("\t4. Quit");
                Console.Write("Select a choice from the menu:");

                string choice = Console.ReadLine();
            
                if (choice == "1")
                {
                    Console.Clear();
                    //Breathing activity code session
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
                    breathingActivity.Run();
                    Console.Clear();
                }
                else if(choice == "2")
                {
                    //Reflecting activity code
                }
                else if (choice == "3")
                {
                    //Listing activity code
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