// This class is responsible for creating the interface and managing user interaction with that interface.

using System.Net;

public class UserEntry
{
    List<string>  menu = new List<string>();
    public UserEntry()
    {
        // The function of this constructor method is to initialize the interface, 
        // which at the moment just means listing the questions.
        menu.Add("1. Write");
        menu.Add("2. Display");
        menu.Add("3. Load");
        menu.Add("4. Save");
        menu.Add("5. Exit");
        
    }

    public int screenMenu()
    {
        bool exitMenu = false;
        string userChoice;
        int choice = 0;
        while (exitMenu == false)
        {
                
            // Setting up and displaying the start menu.
            Console.Clear();
            Console.WriteLine("Please select one of the following choices, typing the corresponding number:");
            Console.WriteLine("");
            foreach (string m in menu)
            {
                Console.WriteLine($"{m}. ");
            }
            Console.WriteLine("");

            // Collecting user input, response.
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            Console.Clear();

            // Checking if user input is a number
            if(int.TryParse(userChoice, out int number) == true)
            {
                choice = int.Parse(userChoice);
                if (choice >= 1 && choice <=5)
                {
                    exitMenu = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, valid inputs are between 1 and 5.");
                    Console.Clear();
                }

            }
            else
            {
                Console.WriteLine("You have entered an invalid input, please enter one of the menu options.");
                Console.Clear();
            }          
            
        }
        return choice;
    }


}