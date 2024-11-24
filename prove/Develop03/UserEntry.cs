// This class is responsible for creating the interface and managing user interaction with that interface.

using System.Net;

public class UserEntry
{
    List<string>  menu = new List<string>();
    public UserEntry()
    {
        // The function of this constructor method is to initialize the interface, 
        // which at the moment just means listing the questions.
        menu.Add("Type 0 for Psalm 103:2-3");
        menu.Add("Type 1 for Deuteronomy 32:39");
        menu.Add("Type 2 for 1 Nephi 3:7");
        menu.Add("Type 3 for 2 Nephi 2:25");
        menu.Add("Type 4 for 2 Nephi 32:3");
        menu.Add("Type 5 for Doctrine and Covenants 82:10");
        menu.Add("Type 6 for Doctrine and Covenants 88:118");
        menu.Add("Type 7 Helaman 5:12");
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
            Console.WriteLine("Select the scripture you wish to memorize by typing the corresponding number in the following menu.");
            Console.WriteLine("");
            foreach (string m in menu)
            {
                Console.WriteLine($"{m}. ");
            }
            Console.WriteLine("");
            Console.Write(">");
            userChoice = Console.ReadLine();
            Console.Clear();

            // Checking if user input is a number
            if(int.TryParse(userChoice, out int number) == true)
            {
                choice = int.Parse(userChoice);
                if (choice >= 0 && choice <=7)
                {
                    exitMenu = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, valid inputs are between 0 and 7.");
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