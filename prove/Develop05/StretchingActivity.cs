
using System.Runtime.CompilerServices;

public class StretchingActivity:Activity
{
    private List<string> _message = new List<string>();
    
    public StretchingActivity(string activityName, string activityDescription, int activityDuration, List<string> message):
    base(activityName,activityDescription,activityDuration)
    {
        this._message = message;
    }
    public void Run()
    {
        Console.Clear();
        string time = base.OpeningMessage();
        if(int.TryParse(time, out int result))
        {
            base.SetActivityDuration(result); // After receiving duration from the user we set the activity duration in class
            base.GetReady(3);
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(base.GetActivityDuration());
            DateTime currentTime = DateTime.Now;
            bool flag = true;
            while (currentTime < futureTime && flag)
            {
                currentTime = DateTime.Now;
                foreach(string m in this._message)
                {
                    currentTime = DateTime.Now;
                    if (currentTime < futureTime)
                    {
                        Console.Clear();
                        Console.Write($"{m} ");
                        base.ShowCountDown(4);
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                
            }
            Console.Clear();
            base.EndingMessage(3);

        }
         else
        {
            Console.Clear();
            Console.Write("Invalid value, press any key to continue.");
            Console.ReadLine();
        }

    }
}