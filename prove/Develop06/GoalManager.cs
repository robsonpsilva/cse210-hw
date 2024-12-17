
using System.ComponentModel;
public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    FileManager _fileManager = new FileManager();

    int _level = 1; //Exceeding requirements
    int _levelBonus = 0;//Exceeding requirements
    int _score = 0;
    bool _flag = true;
    public void Start()
    {
        while (this._flag == true)
        {
            string choice;
            //Shows the amount of points the user has.
            Console.WriteLine($"You have {this._score} points.");
            Console.WriteLine($"Your currently level is: {this._level}");
            Console.WriteLine("");
            //Showing the menu.
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                //Create a new goal
                CreateNewGoal();
            }
            else if(choice == "2")
            {
                ListGoals();
            }
            else if(choice == "3")
            {
                SaveToFile();
            }
            else if(choice == "4")
            {
                LoadFromFile();
                Console.Clear();
                ListGoals();
            }
            else if(choice == "5")
            {
                RecordAnEvent();
                Console.Clear();
                ListGoals();
            }
            else if(choice == "6")
            {
                //Exiting the program
                this._flag = false;
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
        
        Console.Write("Wich type of goal would you like to create? ");
        choice = Console.ReadLine();

        //The following questions are common to all goals, so to simplify the code they will be asked at the beginning.
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
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
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = Console.ReadLine();
                int t;
                isNumeric = int.TryParse(target, out t);
                if (isNumeric==true)
                {
                    Console.Write("What is te bonus for accomplishing it thet many times? ");
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
        Console.Clear();
    }

    private void ListGoals()
    {
        int i = 0;
        Console.Clear();
        Console.WriteLine("The goals are:");
        this._score = 0;
        foreach(Goal g in this._goals)
        {
            i++;
            Console.WriteLine($"{i}. {g.getDetailsString()}");
            this._score += g.GetTotalPoints();

            //-------------Exceeding requirements---------------
            this._level = 1;
            this._levelBonus = 0;
            if (this._score > 1000)
            {
                this._level = 2;
                this._levelBonus = 500;
                this._score += this._levelBonus;
            }
            else if (this._score > 3000)
            {
                this._level = 3;
                this._levelBonus = 1000;
                this._score += this._levelBonus;
            }
            else if (this._score > 10000)
            {
                this._level = 4;
                this._levelBonus = 3000;
                this._score += this._levelBonus;   
            }
        }
    }

    private void RecordAnEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        string choice = Console.ReadLine();
        int c;
        bool isNumeric = int.TryParse(choice, out c);
        if (isNumeric==true)
        {
            c--;
            if(this._goals[c].IsComplete() == false)
            {
                this._goals[c].RecordEvent();
                this._score += this._goals[c].GetTotalPoints();
            }
            else
            {
                Console.WriteLine("This goal has already been completed, it is not possible to register a new event.");
                Console.Write("Type a key to continue. ");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
        else
        {
            Console.WriteLine("");
            Console.Write("Invalid goal's number, please type a key to continue");
            Console.ReadLine();
        }

    }

    private void SaveToFile()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        try
        {
            this._fileManager.SaveToFile(fileName,this._goals,this._score);
        }
        catch  (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Unauthorized access" + ex.Message);
            Console.Write("Type a key to continue. ");
            Console.ReadLine();
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O error" + ex.Message);
            Console.Write("Type a key to continue. ");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred" + ex.Message);
            Console.Write("Type a key to continue. ");
            Console.ReadLine();
        }
        
    }
    private void LoadFromFile()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        try
        {
            List<string> goalsList = _fileManager.LoadFromFile(fileName);
            int line = 0;
            //Overwriting the previous list with new values
            this._goals = new List<Goal>();
            foreach (string goal in goalsList)
            {
                if (line == 0 && int.TryParse(goal, out this._score))
                {
                    line++;
                }
                else
                {
                    string[] parts = goal.Split(":");
                    if(parts[0] == "SimpleGoal")
                    {
                        string[] item = parts[1].Split("~|~");
                        SimpleGoal simpleGoal = new SimpleGoal(item[0], item[1],int.Parse(item[2]));
                        if (item[3].ToLower() == "true")
                        {
                            simpleGoal.RecordEvent();
                        }
                        this._goals.Add(simpleGoal);
                    }
                    else if(parts[0] == "EternalGoal")
                    {
                        string[] item = parts[1].Split("~|~");
                        EternalGoal eternalGoal = new EternalGoal(item[0], item[1],int.Parse(item[2]));
                        this._goals.Add(eternalGoal);
                        eternalGoal.RecordEvent();
                    }
                    else if(parts[0] == "CheckListGoal")
                    {
                        string[] item = parts[1].Split("~|~");
                        CheckListGoal checkListGoal = 
                        new CheckListGoal(item[0], item[1],int.Parse(item[2]),int.Parse(item[3]),int.Parse(item[4]),int.Parse(item[5]));
                        this._goals.Add(checkListGoal);
                    }
                }
                
            }
        }
        catch  (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Unauthorized access" + ex.Message);
            Console.Write("Type a key to continue. ");
            Console.ReadLine();
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O error" + ex.Message);
            Console.Write("Type a key to continue. ");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred" + ex.Message);
            Console.Write("Type a key to continue. ");
            Console.ReadLine();
        }    
    }

}