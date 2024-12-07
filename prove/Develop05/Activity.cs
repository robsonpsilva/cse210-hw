
public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    private string _endingMessage;

    

    

    public Activity(string activityName, string activityDescription, int activityDuration)
    {
        this._activityName = activityName;
        this._activityDescription = activityDescription;
        this._activityDuration = activityDuration;
        this._endingMessage = $"Welcome to the {this._activityName}. {Environment.NewLine}{Environment.NewLine}{this._activityDescription}";
        this._endingMessage += $"{Environment.NewLine}{Environment.NewLine}How long, in seconds, would you like for your session? ";
    }

    public string OpeningMessage()
    {        
        return Console.ReadLine();
    }
    public void EndingMessage()
    {
        Console.WriteLine(this._endingMessage);
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