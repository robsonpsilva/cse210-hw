
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDescription, int activityDuration):
    base(activityName,activityDescription,activityDuration)
    {
        
    }

    public void Run()
    {
        //Asking for the session duration
        string time = base.OpeningMessage();
        if(int.TryParse(time, out int result))
        {
            base.SetActivityDuration(result); // After receiving duration from the user we set the activity duration in class
            Console.Clear();
            Console.WriteLine("Get ready...");
            base.ShowSpinner(5);
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(base.GetActivityDuration());
            DateTime currentTime;

            currentTime = DateTime.Now;
            while (currentTime < futureTime)
            {
                Console.WriteLine("");
                Console.Write("Breathe in...");
                base.ShowCountDown(4);
                Console.WriteLine("");
                Console.Write("Now breathe out...");
                base.ShowCountDown(6);
                Console.WriteLine("");
                currentTime = DateTime.Now;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Well done!!");
            Console.WriteLine("");
            base.ShowSpinner(5);
            base.EndingMessage();
            base.ShowSpinner(5);
        }
        else
        {
            Console.Clear();
            Console.Write("Invalid value, press any key to continue.");
            Console.ReadLine();
        }

    }

}