
using System.Runtime.CompilerServices;

public abstract class Activity
{
    private string _date;
    private int _minutes;
    public Activity(string date, int minutes){
        this._date = date;
        this._minutes = minutes;
    }
    protected string GetDate()
    {
        return this._date;
    }

    protected int GetLenghtInMinutes()
    {
        return this._minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual void GetSummary(string activityType)
    {
        Console.WriteLine($"{this.GetDate()} {activityType} ({this.GetLenghtInMinutes()})- Distance {this.GetDistance()} km, speed: {this.GetSpeed()} kph, Pace: {this.GetPace()}");
    }
}