using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
       
       Console.Clear();
       Console.WriteLine("Hello Foundation3 World!");

        List <Activity> activities = new List<Activity>();

        CiclingActivity ciclingActivity = new CiclingActivity("17 december 2024", 30, 10);
        RunningActivity runningActivity = new RunningActivity("15 december 2024", 25, 2);
        SwimmingActivity swimmingActivity = new SwimmingActivity("10 december 2024", 12, 8);

        activities.Add(ciclingActivity);
        activities.Add(runningActivity);
        activities.Add(swimmingActivity);

        foreach (Activity a in activities)
        {
            a.GetSummary("");
        
        }
    }
}