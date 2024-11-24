using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        
        //Loads the menu with eight scripture options to be memorized.
        UserEntry uDisplay = new UserEntry();
        int choice = uDisplay.screenMenu();
        Scripture scripture = new Scripture();
        Reference r = scripture.getScreenScripture(choice);

        string prompt = "";
        while (prompt != "quit")
        {
            Console.Clear(); //Cleaning up the console to provide a less visually cluttered prompt.
            Console.WriteLine(r.getHiddenReferenceString()); //Displaying the text of the scripture reference.
            Console.WriteLine("");
            Console.Write("Press the enter key or, if you want to exit, type the word quit and then press enter.");
            prompt = Console.ReadLine();
            
            r.hideWord();
            
            if (r.isFullHidden())
            {
                Console.WriteLine("Encerrando o programa!");
                prompt = "quit";
            }
        }
    
    }
}