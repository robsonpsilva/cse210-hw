
public class RunningActivity:Activity
{
    private double _distance; //kilometers
    public RunningActivity(string date, int minutes, double distance):base(date,minutes)
    {
        this._distance = distance; //in kilometers
    }

    public override double GetDistance()
    {
        return this._distance; // in kilometers
    }
    public override double GetSpeed()
    {
        return (this.GetDistance() / base.GetLenghtInMinutes()) * 60; // Speed im km per hour
    }
    public override double GetPace()
    {
        return 60 / this.GetSpeed(); // min per km
    }
    public override void GetSummary(string activityType)
    {
        base.GetSummary("Running");
    }
}