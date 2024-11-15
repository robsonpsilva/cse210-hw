// This class is responsible for creating the interface and managing user interaction with that interface.

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
        Console.WriteLine("Please select one of the following choices, typing the corresponding number.:");
        Console.WriteLine("");
        foreach (string m in menu)
        {
            Console.WriteLine($"{m}");
        }
        return 0;

    }


}