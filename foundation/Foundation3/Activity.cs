
using System.Runtime.CompilerServices;

public abstract class Activity
{
    private string _date;
    private double _lenght;
    public Activity(string date, int lenght){
        this._date = date;
        this._lenght = lenght;
    }
    protected string GetDate()
    {
        return this._date;
    }

    protected double GetLenghtInMinutes()
    {
        return this._lenght;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public virtual void GetSummary(string activityType)
    {
        Console.WriteLine($"{this.GetDate()} {activityType} ({this.GetLenghtInMinutes().ToString("F2")})- Distance {this.GetDistance().ToString("F2")} km, speed: {this.GetSpeed().ToString("F2")} kph, Pace: {this.GetPace().ToString("F2")} min per km");
    }
}