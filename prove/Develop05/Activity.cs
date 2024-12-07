
public class Activity
{
    string _activityName;
    string _activityDescription;
    int _activityDuration;
    string _endingMessage;

    

    

    public Activity(string activityName, string activityDescription, int activityDuration)
    {
        this._activityName = activityName;
        this._activityDescription = activityDescription;
        this._activityDuration = activityDuration;
    }

    public string OpeningMessage()
    {
        
        string message = $"Welcome to the {this._activityName}. {Environment.NewLine}{Environment.NewLine}{this._activityDescription}";
        message += $"{Environment.NewLine}{Environment.NewLine}How long, in seconds, would you like for your session? ";
        Console.Write(message);
        return Console.ReadLine();
    }
    public void EndingMessage()
    {
        string message = $"{this._endingMessage}{Environment.NewLine}";
        message += $"you have completed another {this._activityDuration} seconds of the {this._activityName}.";
        Console.WriteLine(message);
    }

    public void ShowSpinner(int  duration)
    {
        int i = 0;
        while(i<=duration)
        {
            i++;
            Console.Write("\\");
            Thread.Sleep(333);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("-");
            Thread.Sleep(333);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(333);
            Console.Write("\b \b"); // Erase the + character
        }
    }

    public void ShowCountDown(int seconds)
    {
        int i = seconds;
        while(i>0)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            if (i >=10)
            {
                Console.Write("\b \b");
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b \b");
            }
            
            i-=1;
        }
    }

    public void SetActivityDuration(int activityDuration)
    {
        this._activityDuration = activityDuration;
    }
    public int GetActivityDuration()
    {
        return this._activityDuration;
    }

  

}