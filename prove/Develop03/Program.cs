using System;
using System.Security.Cryptography;
/*
        Exceeding Requirements - The program works with a library of eight scriptures, 
        which can be selected by the user through the menu.
        The library is loaded into memory in the Scripture class constructor.
        Please look in the Scripture class constructor to see where the library is loaded.

        Exceeding Requirements - The system allows random loading of scriptures
        When you press 8 in the menu, the system will load the scripture randomly.

*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Random random = new Random();
        //Loads the menu with eight scripture options to be memorized.
        UserEntry uDisplay = new UserEntry();
        int choice = uDisplay.screenMenu();
        if (choice == 8)
        {
            //Exceeding Requirements 
            //Allows you to choose scriptures randomly.
            choice = random.Next(0, 8);
        }
        Scripture scripture = new Scripture();
        Reference r = scripture.getScreenScripture(choice);

        Console.Clear(); //Cleaning up the console to provide a less visually cluttered prompt.
        Console.WriteLine("Attention! Please read the following instructions carefully.");
        Console.WriteLine("The selected scripture will be presented to you.");
        Console.WriteLine("Each time you press the Enter key, a word will be hidden in the selected scripture.");
        Console.WriteLine("At any time, if you wish to exit, type the word quit and press the Enter key.");
        Console.Write("Press any key to continue: ");
        Console.ReadLine();

        string prompt = "";
        while (prompt != "quit")
        {
            Console.Clear(); //Cleaning up the console to provide a less visually cluttered prompt.
            Console.WriteLine(r.getHiddenReferenceString()); //Displaying the text of the scripture reference.
            Console.WriteLine("");
            
            Console.Write(">");
            prompt = Console.ReadLine();
            
            r.hideWord();
            
            if (r.isFullHidden())
            {
                Console.WriteLine("Program exit.");
                prompt = "quit";
            }
        }
    
    }
}