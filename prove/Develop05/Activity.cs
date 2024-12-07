
public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    private string _endingMessage;
    private string _openingMessage;

    

    

    public Activity(string activityName, string activityDescription, int activityDuration)
    {
        this._activityName = activityName;
        this._activityDescription = activityDescription;
        this._activityDuration = activityDuration;

        this._openingMessage = $"Welcome to the {this._activityName}. {Environment.NewLine}{Environment.NewLine}{this._activityDescription}";
        this._openingMessage+= $"{Environment.NewLine}{Environment.NewLine}How long, in seconds, would you like for your session? ";
    }

    public string OpeningMessage()
    {
        Console.Write(this._openingMessage);       
        return Console.ReadLine();
    }
    public void EndingMessage(int delayInSeconds)
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        ShowSpinner(delayInSeconds);
        this._endingMessage = $"you have completed another {this._activityDuration} seconds of the {this._activityName}.";
        Console.WriteLine(this._endingMessage);
        ShowSpinner(delayInSeconds);
    }

    public void GetReady(int delayInSeconds)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(delayInSeconds);
        Console.WriteLine("");
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