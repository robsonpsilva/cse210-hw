
public class Activity
{
    string _activityName;
    string _activityDescription;
    int activityDuration;
    string _endingMessage;
    

    public Activity(string activityName, string activityDescription, int activityDuration)
    {
        this._activityName = activityName;
        this._activityDescription = activityDescription;
        this.activityDuration = activityDuration;
    }

    public void OpeningMessage()
    {
        
        string message = $"Welcome to the {this._activityName} Activity. {Environment.NewLine}{this._activityDescription}";
        message += $"{Environment.NewLine}How long, in seconds, would you like for your session?";
        Console.WriteLine(message);
    }
    public void EndingMessage()
    {
        string message = $"{this._endingMessage}{Environment.NewLine}";
        message += $"you have completed another {this.activityDuration} of the {this._activityName}.";
        Console.WriteLine();
    }

    public void ShowSpinner(int  duration)
    {
        int i = 0;
        Console.Clear();
        while(i<=60)
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
            Console.Write("\b \b");
            Console.Write("\b \b");
            i-=1;
        }
    }

}