
public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    int _score = 0;
    bool flag = true;
    public void Start()
    {
        while (flag == true)
        {
            string choice;
            //Shows the amount of points the user has.
            Console.Clear();
            Console.WriteLine($"You have {this._score}");
            Console.WriteLine("");
            //Showing the menu.
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu:");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                //Create a new goal
                CreateNewGoal();
            }
            else if(choice == "2")
            {

            }
            else if(choice == "3")
            {

            }
            else if(choice == "4")
            {

            }
            else if(choice == "5")
            {

            }
            else if(choice == "6")
            {
                //Exiting the program
                flag = false;
            }
            else
            {
                Console.Write("Invalid option, press a key to continue!");
                Console.ReadLine();   
            }

        }
    }

    private void CreateNewGoal()
    {
        string choice;
        string name;
        string description;
        string points;
        string target;
        string bonus;

        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. CheckList Goal");
        
        Console.Write("Wich type of goal would you like to create?");
        choice = Console.ReadLine();

        //The following questions are common to all goals, so to simplify the code they will be asked at the beginning.

        Console.WriteLine("");
        Console.Write("What is the name of your goal?");
        name = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("What is a short description of it?");
        description = Console.ReadLine();

        Console. WriteLine("");
        Console.Write("What is the amount of points associated with this goal? ");
        points = Console.ReadLine();
        int p;
        bool isNumeric = int.TryParse(points, out p);
        if (isNumeric==true)
        {
            if (choice == "1")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, p);
                this._goals.Add(simpleGoal);
            }
            else if(choice == "2")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, p);
                this._goals.Add(eternalGoal);
            }
            else if(choice == "3")
            {
                Console.WriteLine("");
                Console.Write("How many times does this goal need to be accomplished for a bonus?");
                target = Console.ReadLine();
                int t;
                isNumeric = int.TryParse(target, out t);
                if (isNumeric==true)
                {
                    Console.WriteLine("");
                    Console.Write("What is te bonus for accomplishing it thet many times?");
                    bonus = Console.ReadLine();
                    int b;
                    isNumeric = int.TryParse(bonus, out b);
                    if(isNumeric == true)
                    {
                        CheckListGoal checkListGoal = new CheckListGoal(name, description, p, 0, t, b);
                        this._goals.Add(checkListGoal);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("The bonus entered is invalid, please press a key to continue");
                        Console.ReadLine(); 
                    }
                    
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write("The number of times entered is invalid, please press a key to continue");
                    Console.ReadLine();
                }
                
            }
        }
        else
        {
            Console.WriteLine("");
            Console.Write("The amount of points is invalid, please type a key to continue");
            Console.ReadLine();
        }
    }

}