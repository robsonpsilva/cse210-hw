using System;
using System.Security.Cryptography;
/*
        Exceeding Requirements - Scripture Library - The program works with a library of eight scriptures, 
        which can be selected by the user through the menu.
        The library is loaded into memory in the Scripture class constructor.
        Please look in the Scripture class constructor to see where the library is loaded.

        Exceeding Requirements - Randomly selected scriptures - The system allows random loading of scriptures.
        When you press 8 in the menu, the system will load the scripture randomly.

*/
class Program
{
    static void Main(string[] args)
    {
        
        Random _random = new Random();
        //Loads the menu with eight scripture options to be memorized.
        UserEntry _uDisplay = new UserEntry();
        int _choice = _uDisplay.screenMenu();
        Scripture _scripture = new Scripture();
        string _prompt = "";

        Console.WriteLine("Hello Develop03 World!");

        if (_choice == 8)
        {
            //Exceeding Requirements 
            //Allows you to choose scriptures randomly.
            _choice = _random.Next(0, 8);
        }

        Console.Clear(); //Cleaning up the console to provide a less visually cluttered prompt.
        Console.WriteLine("Attention! Please read the following instructions carefully.");
        Console.WriteLine("The selected scripture will be presented to you.");
        Console.WriteLine("Each time you press the Enter key, a word will be hidden in the selected scripture.");
        Console.WriteLine("At any time, if you wish to exit, type the word quit and press the Enter key.");
        Console.Write("Press any key to continue: ");
        Console.ReadLine();
        
        while (_prompt != "quit")
        {
            Console.Clear(); //Cleaning up the console to provide a less visually cluttered prompt.
            Console.WriteLine(_scripture.getScreenScripture(_choice)
            .getHiddenReferenceString()); //Displaying the text of the scripture reference.
            Console.WriteLine("");
            
            Console.Write(">");
            _prompt = Console.ReadLine();
            
            _scripture.hideRandomWords(); // This function will hide a word in the scripture.
            
            if (_scripture.isCompletelyHidden())
            {
                Console.WriteLine("Program exit.");
                _prompt = "quit";
            }
        }
    
    }
}